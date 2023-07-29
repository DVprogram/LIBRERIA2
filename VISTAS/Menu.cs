using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRERIA2.VISTAS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            menuvertical.Width = 0;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (menuvertical.Width == 123)
            {
                menuvertical.Width = 0;
            }
            else menuvertical.Width = 123;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AGREGAR agregarControl = new AGREGAR();
            agregarControl.Dock = DockStyle.Fill;

            panelcontenedor.Controls.Clear();
            panelcontenedor.Controls.Add(agregarControl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VERPRODUCTOS agregarControl =  new VERPRODUCTOS();
            agregarControl.Dock = DockStyle.Fill;

            panelcontenedor.Controls.Clear();
            panelcontenedor.Controls.Add(agregarControl);
            menuvertical.Width = 0;

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Nuevaventa agregarcontrol= new Nuevaventa();
            agregarcontrol.Dock= DockStyle.Fill;
            panelcontenedor.Controls.Clear();
            panelcontenedor.Controls.Add(agregarcontrol);
        }
    }
}
