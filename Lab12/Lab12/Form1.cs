using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public delegate void AgregarComidaDelegate(string name, double prote, double carbos, double grasa);
    public delegate void EliminarComidaDelegate(string name, double prote, double carbos, double grasa);
    public partial class Form1 : Form
    {
        public event AgregarComidaDelegate OnAgregarComida;
        public event EliminarComidaDelegate OnEliminarComida;
        public Form1()
        {
            InitializeComponent();
            panel1.Show();
            panel2.Show();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            if (OnAgregarComida != null)
            {
                OnAgregarComida.Invoke(nametxt.Text, double.Parse(protetxt.Text),double.Parse(carbtxt.Text),double.Parse(grasatxt.Text));
                protetxt.Clear();
                nametxt.Clear();
                carbtxt.Clear();
                grasatxt.Clear();
            }
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            if (OnEliminarComida != null)
            {
                ComidasList.Items.Remove(ComidasList.SelectedItem);
            }
        }
        public void EliminarComida(Clases.Alimento alimento)
        {
            ComidasList.Items.Remove(alimento);
        }
        public void AgregarComida(Clases.Alimento alimento)
        {
            ComidasList.Items.Add(alimento);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
