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

namespace Login
{
    public partial class FormLogin : Form
    {
        UsuarioModel usuarioModel = new UsuarioModel();
        ColoresARGB Colores = new ColoresARGB();
        public FormLogin()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {


            SingletonFont cargaF = SingletonFont.GetInstancia();


            ApplyFontsToControls(cargaF);
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
            GuardarUltimoUsuario();
            DesactivarControles(false);
            BtnIniciar.BackGroudColor = Colores.Secondary;
            // verificar conexion timeout exception
            bool login = false;
            try
            {

                login = await usuarioModel.LoginUser(TxtUsuario.Text, TxtPassword.Text);
            }
            catch (TimeoutException ex)
            {
                NSMessageBox.NSMessageBox mensaje = new NSMessageBox.NSMessageBox();
                mensaje.ShowDialog("Error base de datos", "Paso demasiado tiempo para conectarse con la base de datos.\n" + ex.Message, NSMessageBox.Iconos.Cross, NSMessageBox.Botones.Aceptar);
                return;

            }catch(InvalidOperationException ex)
            {
                NSMessageBox.NSMessageBox mensaje = new NSMessageBox.NSMessageBox();
                mensaje.ShowDialog("Error base de datos", "Ya hay una conexion abierta con laba se de datos.\n" + ex.Message, NSMessageBox.Iconos.Cross, NSMessageBox.Botones.Aceptar);
                return;
            }
            finally
            {
                TxtPassword.Text = "";
                TxtUsuario.Focus();
            }

            if (login)
            {

                this.Hide();
            }
            else
            {
                
                LblIcoError.Visible = true;
                LblErrorUserPass.Visible = true;
                DesactivarControles(true);



            }

        }
        private void DesactivarControles(bool habilitacion)
        {
            BtnIniciar.Enabled = habilitacion;
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
    }
}
