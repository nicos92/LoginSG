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

using Newtonsoft.Json;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            

            SingletonFont cargaF = SingletonFont.GetInstancia();
            
            
            ApplyFontsToControls(cargaF);
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
            TxtPassword.Text = "";
            TxtUsuario.Text = "";
            TxtUsuario.Focus();
        }
    }
}
