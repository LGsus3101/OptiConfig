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
using System.Xml;

namespace Aplicacion_de_Identificacion
{
    public partial class FormProdigy : Form
    {
        public FormProdigy()
        {
            InitializeComponent();
        }

        private void FormProdigy_Load(object sender, EventArgs e)
        {
            PicBoxLogo.Image = Properties.Resources.Commscope_Logo_2011;
            PicBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            PicBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox2.Visible= false;
            PicBox3.Visible= false;
        }
        private async void TxtSerial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string serial = TxtSerial.Text.Trim();
                e.SuppressKeyPress = true;
                if (string.IsNullOrEmpty(serial))
                {
                    MessageBox.Show("Por Favor ingrese un numero de serie.");
                    return;
                }
                var service = new MaterialServices("http://gpr1pwbtsngs01:8090/graphql");
                string resultado = await service.ObtenerMaterialPorSerialAsync(serial);

                TxtMaterial.Text = resultado;
                TxtSerial.Clear();
                TxtSerial.Focus();
            }
        }
        private void TxtMaterial_TextChanged(object sender, EventArgs e)
        {
            string materialNumber = TxtMaterial.Text.Trim();
            if (materialNumber.Contains("-"))
            {
                string[] partes = materialNumber.Split('-');
                if (partes.Length > 1 && partes[1].Length > 0)
                {
                    char letraClave = partes[1][0];
                    MostrarImagen(letraClave);
                }
            }
        }
        void MostrarImagen(char indice)
        {
            switch (indice)
            {
                case 'H':
                    PicBox1.Image = Properties.Resources.ConectorH;
                    break;
                case 'X':
                    PicBox1.Image = Properties.Resources.ConectorX;
                    break;
                case 'B':
                    PicBox1.Image = Properties.Resources.ConectorB;
                    break;
                case 'F':
                    PicBox1.Image = Properties.Resources.ConectorF;
                    break;
                case 'A':
                    PicBox1.Image = Properties.Resources.ConectorA;
                    break;
            }
        }




        //private List<char> ObtenerLetraClave(string material)
        //{
        //    var letras = new List<char>();
        //    if (string.IsNullOrWhiteSpace(material)) return letras;

        //    int primerGuion = material.IndexOf('-');
        //    if (primerGuion >= 0 && primerGuion + 1 < material.Length)
        //    {
        //        for (int i = 1; i <= 2 && primerGuion + i < material.Length; i++)
        //        {
        //            char c = material[primerGuion + i];
        //            if (char.IsLetter(c)) letras.Add(c);
        //        }
        //    }
        //    return letras;
        //}

        //private readonly Dictionary<char, Image> imgConectores = new Dictionary<char, Image>
        //{
        //    {'H', Properties.Resources.ConectorH },
        //    {'X', Properties.Resources.ConectorX },
        //    {'B', Properties.Resources.ConectorB },
        //    {'F', Properties.Resources.ConectorF },
        //    {'A', Properties.Resources.ConectorA }
        //};
        //private Image InvertirImagen(Image original)
        //{
        //    if (original == null) return null;
        //    Bitmap bmp = new Bitmap(original);
        //    bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
        //    return bmp;
        //}
        //private void MostrarImagenes(List<char> letras)
        //{
        //    PicBox1.Visible = false;
        //    PicBox2.Visible = false;
        //    PicBox3.Visible = false;

        //    var imgValidadas = letras
        //        .Where(letra => imgConectores.ContainsKey(letra))
        //        .Select(letra => imgConectores[letra])
        //        .ToList();

        //    if (imgValidadas.Count == 1)
        //    {
        //        PicBox1.Image = imgValidadas[0];
        //        PicBox1.Visible = true;
        //    }
        //    else if (imgValidadas.Count >= 2)
        //    {
        //        PicBox2.Image = imgValidadas[0];
        //        PicBox3.Image = InvertirImagen(imgValidadas[1]);
        //        PicBox2.Visible = true;
        //        PicBox3.Visible = true;
        //    }
        //}
        //private void TxtMaterial_TextChanged(object sender, EventArgs e)
        //{
        //    var letrasClave = ObtenerLetraClave(TxtMaterial.Text);
        //    MostrarImagenes(letrasClave);
        //}


    }
}
