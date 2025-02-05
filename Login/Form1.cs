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
        private Dictionary<string, Font> _fontCollection = new Dictionary<string, Font>();
        public Form1()
        {
            InitializeComponent();
            LoadFontsFromConfig();
            ApplyFontsToControls();
        }

        

        private void LoadFontsFromConfig()
        {
            //Properties.Resources.SUSE_VariableFont_wght.ttf
            // Lee el archivo de configuración
            string configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fonts.json");
            if (!File.Exists(configFilePath))
            {
                MessageBox.Show("El archivo de configuración de fuentes no existe.");
                return;
            }

            string json = File.ReadAllText(configFilePath);
            var fontSettings = JsonConvert.DeserializeObject<FontSettings>(json);

            // Carga cada fuente desde los recursos incrustados
            foreach (var fontConfig in fontSettings.Fonts)
            {
                var font = LoadFontFromResource(fontConfig.ResourceName, fontConfig.Size);
                if (font != null)
                {
                    _fontCollection[fontConfig.Name] = (Font) font;
                }
            }
        }

        private object LoadFontFromResource(string fontResourceName, float size)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            using (var stream = assembly.GetManifestResourceStream(fontResourceName))
            {
                if (stream == null)
                {
                    MessageBox.Show($"No se pudo cargar la fuente: {fontResourceName}");
                    return null;
                }

                byte[] fontData = new byte[stream.Length];
                stream.Read(fontData, 0, (int)stream.Length);

                IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

                PrivateFontCollection privateFonts = new PrivateFontCollection();
                privateFonts.AddMemoryFont(fontPtr, fontData.Length);

                Marshal.FreeCoTaskMem(fontPtr);

                return new Font(privateFonts.Families[0], size);
            }
        }

        private void ApplyFontsToControls()
        {
            LblUsuario.Font = _fontCollection["SuseBold16"];
            LblPassword.Font = _fontCollection["SuseBold16"];
            BtnIniciar.Font = _fontCollection["SuseRegular14"];

        }
    }
}
