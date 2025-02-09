using Login.Fonts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Model;


using Newtonsoft.Json;
using Common.Cache;
using System.Threading;

namespace Login
{
    public partial class FormLogin : Form
    {
        UsuarioModel usuarioModel = new UsuarioModel();
        ColoresARGB Colores = new ColoresARGB();
        NSMessageBox.NSMessageBox mensaje = new NSMessageBox.NSMessageBox();
        public FormLogin()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

            //SingletonFont cargaF = SingletonFont.GetInstancia();


            //ApplyFontsToControls(cargaF);
            CargarUltimoUsuario();

        }

        private void CargarUltimoUsuario()
        {
            if (Properties.Settings.Default.Usuario != "")
            {
                TxtUsuario.Text = Properties.Settings.Default.Usuario;
                RBtnRecordarUsuario.Checked = true;
            }
        }

        private void ApplyFontsToControls(SingletonFont cargaF)
        {

            LblUsuario.Font = cargaF.FontCollection["Suse_16_Bold"];
            TxtUsuario.Font = cargaF.FontCollection["Suse_12_Regular"];
            LblPassword.Font = cargaF.FontCollection["Suse_16_Bold"];
            TxtPassword.Font = cargaF.FontCollection["Suse_12_Regular"];

            BtnIniciar.Font = cargaF.FontCollection["Suse_14_Bold"];

        }

        private async void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (!BackWorkerProgressBar.IsBusy)
            {
                BackWorkerProgressBar.RunWorkerAsync();

            }

            GuardarUltimoUsuario();
            DesactivarControles(false);
            BtnIniciar.BackGroudColor = Colores.Secondary;
            await IniciarSesion();

        }

        private async Task IniciarSesion()
        {
            // verificar conexion timeout exception
            bool login = false;
            try
            {

                login = await usuarioModel.LoginUser(TxtUsuario.Text, TxtPassword.Text);
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                DetenerProgressBar();

                mensaje.ShowDialog("Error en Base de datos", ex.Message, NSMessageBox.Iconos.Cross, NSMessageBox.Botones.Aceptar);

                return;
            }
            catch (TimeoutException ex)
            {
                DetenerProgressBar();

                mensaje.ShowDialog("Error en Base de datos", "Paso demasiado tiempo para conectarse con la base de datos.\n" + ex.Message, NSMessageBox.Iconos.Cross, NSMessageBox.Botones.Aceptar);

                return;

            }
            catch (InvalidOperationException ex)
            {
                DetenerProgressBar();
                mensaje.ShowDialog("Error en Base de datos", "Ya hay una conexion abierta con la base de datos.\n" + ex.Message, NSMessageBox.Iconos.Cross, NSMessageBox.Botones.Aceptar);


                return;
            }
            finally
            {
                TxtPassword.Text = "";
                DesactivarControles(true);

                TxtUsuario.Focus();
            }

            DetenerProgressBar();
            if (login)
            {
                ErrorUserPass(false);
                mensaje.ShowDialog("Ventana principal", "Bienvenido a la aplicacion", NSMessageBox.Iconos.Check, NSMessageBox.Botones.Aceptar);
            }
            else
            {
                ErrorUserPass(true);
                DesactivarControles(true);



            }
        }

        private void DetenerProgressBar()
        {
            if (BackWorkerProgressBar.IsBusy)
            {
                BackWorkerProgressBar.CancelAsync();

            }
        }
            

        private void ErrorUserPass(bool vista)
        {
            LblIcoError.Visible = vista;
            LblErrorUserPass.Visible = vista;
        }

        private void DesactivarControles(bool habilitacion)
        {
            TxtUsuario.Enabled = habilitacion;
            TxtPassword.Enabled = habilitacion;
        }

        private void GuardarUltimoUsuario()
        {

            if (RBtnRecordarUsuario.Checked)
            {
                Properties.Settings.Default.Usuario = TxtUsuario.Text;
                Properties.Settings.Default.Save();

            }

        }

        private void EnabledBtnIniciar()
        {
            BtnIniciar.Enabled = TxtUsuario.Text != "" && TxtPassword.Text != "";
        }

        private void BtnIniciar_EnabledChanged(object sender, EventArgs e)
        {
            if (BtnIniciar.Enabled)
            {
                BtnIniciar.BackGroudColor = new ColoresARGB().Primary;
            }
            else
            {
                BtnIniciar.BackGroudColor = new ColoresARGB().Secondary;

            }
        }

        private void TxtUsuario__TextChanged(object sender, EventArgs e)
        {
            EnabledBtnIniciar();
        }

        private void TxtPassword__TextChanged(object sender, EventArgs e)
        {
            EnabledBtnIniciar();

        }

        private async void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            await EnviarIniciarSesion(e);
        }
        private async void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            await EnviarIniciarSesion(e);
        }

        private async Task EnviarIniciarSesion(KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (TxtUsuario.Text != "" && TxtPassword.Text != "")
                {

                    if (!BackWorkerProgressBar.IsBusy)
                    {
                        BackWorkerProgressBar.RunWorkerAsync();
                    }
                    GuardarUltimoUsuario();
                    DesactivarControles(false);
                    BtnIniciar.BackGroudColor = Colores.Secondary;
                    await IniciarSesion();
                }
            }
        }

       

       

        private void BackWorkerProgressBar_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            while (toolStripProgressBar1.Value < toolStripProgressBar1.Maximum)
            {
                // Comprobar si se ha solicitado la cancelación
                if (BackWorkerProgressBar.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                // Realizar el trabajo en segundo plano
                Thread.Sleep(100); // Simulamos una tarea que toma tiempo

                // Reportar progreso
                if (i != 99)
                {


                    i++;
                    BackWorkerProgressBar.ReportProgress(i);
                }
            }
        }

        private void BackWorkerProgressBar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void BackWorkerProgressBar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar1.Value = 0;

            
        }
    }
}
