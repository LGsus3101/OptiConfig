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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void BtnAppRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.FormClosed += (s, args) => this.Show();
            formRegistro.Show();
        }

        private void BtnAppProdigy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProdigy formProdigy = new FormProdigy();
            formProdigy.FormClosed += (s, args) => this.Show();
            formProdigy.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
