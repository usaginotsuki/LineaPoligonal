using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineaPoligonal
{
    public partial class Form1 : Form
    {

        private Linea objPolygon = new Linea();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picLienzo_MouseMove(object sender, MouseEventArgs e)
        {
            txtX.Text = e.X.ToString();
            txtY.Text = e.Y.ToString();
        }

        private void picLienzo_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left){
                objPolygon.DrawPoligon(picLienzo, txtX, txtY);
            }
            if (e.Button == MouseButtons.Right)
            {
                objPolygon.EndPolygon(picLienzo, txtX, txtY);
            }

        }
    }
}
