﻿using Login.Fonts;
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

using Newtonsoft.Json;
using Guia_5;

namespace Login
{
    public partial class FormLogin : Form
    {
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

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            GuardarUltimoUsuario();
            TxtPassword.Text = "";
            TxtUsuario.Text = "";
            TxtUsuario.Focus();

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
