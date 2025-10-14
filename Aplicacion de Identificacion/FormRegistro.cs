using Aplicacion_de_Identificacion.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_de_Identificacion
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            PicBoxLogo.Image = Properties.Resources.Commscope_Logo_2011;
            BoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private async void TxtSerialNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string serial = TxtSerialNumber.Text.Trim();
                e.SuppressKeyPress = true;
                if (string.IsNullOrEmpty(serial))
                {
                    MessageBox.Show("Por Favor ingrese un numero de serie.");
                    return;
                }
                var service = new MaterialServices("http://gpr1pwbtsngs01:8090/graphql");
                string resultado = await service.ObtenerMaterialPorSerialAsync(serial);

                TxtMaterialNumber.Text = resultado;
                TxtSerialNumber.Clear();
                TxtSerialNumber.Focus();
            }
        }

        (string prefijo, string gpoInterno, string sufijo) ExtraerPartes(string material)
        {
            var partes = material.Split('-');
            if (partes.Length < 3) return ("", "", "");

            string prefijo = partes[0];
            string gpoInterno = partes[1];
            string sufijo = partes[2];

            return (prefijo, gpoInterno, sufijo);
        }

        string DeterminarGrupo(string material)
        {
            string[] patchcord = {"HH","XX","HX", "JJ", "MM", "LL" };
            string[] hibrido = {"AL","AM","HL","HJ","HM","HN","XJ","XL","XM","QJ"};
            string[] pigtail = {"H0","X0","J0","A0","M0","L0"};

            var (prefijo, gpoInterno, sufijo) = ExtraerPartes(material);
            if (string.IsNullOrEmpty(prefijo) || string.IsNullOrEmpty(gpoInterno) || string.IsNullOrEmpty(sufijo))
                return "Desconocido";

            // Patchcord
            if (patchcord.Any(p => gpoInterno.StartsWith(p)) &&
                (sufijo.EndsWith("F") || sufijo.EndsWith("M")))
                return "Patchcord";

            // Hibrido
            if (hibrido.Any(p => gpoInterno.StartsWith(p)) &&
                (sufijo.EndsWith("F") || sufijo.EndsWith("M")))
                return "Hibrido";

            // Pigtail
            if (pigtail.Any(p => gpoInterno.StartsWith(p)) &&
                (sufijo.EndsWith("F") || sufijo.EndsWith("M")))
                return "Pigtail";

            // Spool FR
            if (sufijo.EndsWith("FR"))
                return "Spool FR";

            // Spool FL
            if (sufijo.EndsWith("FL"))
                return "Spool FL";

            return "Desconocido";
        }

        void MostrarVisual(string material)
        {
            string grupo = DeterminarGrupo(material);
            switch (grupo)
            {
                case "Patchcord":
                    BoxImage.Image = Properties.Resources.Patchcord;
                    break;
                case "Patchcord Hib":
                    BoxImage.Image = Properties.Resources.Patchcord;
                    break;
                case "Hibrido":
                    BoxImage.Image = Properties.Resources.Hibrido;
                    break;
                case "Pigtail":
                    BoxImage.Image = Properties.Resources.Pigtail;
                    break;
                case "Spool FL":
                    BoxImage.Image = Properties.Resources.Spool_FL;
                    break;
                case "Spool FR":
                    BoxImage.Image = Properties.Resources.Spool_FR;
                    break;
            }
        }

        private void TxtMaterialNumber_TextChanged(object sender, EventArgs e)
        {
            MostrarVisual(TxtMaterialNumber.Text);
        }
    }
}
