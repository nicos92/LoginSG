using Login.Fonts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public class CargaFuentes
    {
        private Dictionary<string, Font> _fontCollection = new Dictionary<string, Font>();

        public Dictionary<string, Font> FontCollection
        {
            get
            {
                return _fontCollection;
            }

            set
            {
                _fontCollection = value;
            }
        }

       

        public void LoadFontsFromConfig()
        {
            //Properties.Resources.SUSE_VariableFont_wght.ttf
            // Lee el archivo de configuración
            string configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fonts\\fonts.json");
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
                var font = LoadFontFromResource(fontConfig.ResourceName, fontConfig.Size, fontConfig.Weight);
                if (font != null)
                {
                    FontCollection[fontConfig.Name] = (Font)font;
                }
            }
        }

        private object LoadFontFromResource(string fontResourceName, float size, string weight)
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

                return new Font(privateFonts.Families[0], size, GetMiFontStyle(weight));
            }
        }

        private FontStyle GetMiFontStyle(string weight)
        {
            if (weight == "Bold")
            {
                return FontStyle.Bold;
            }

            if (weight == "Regular")
            {
                return FontStyle.Regular;
            }
            return FontStyle.Regular;


        }
    }
}
