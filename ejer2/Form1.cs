using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string myString = this.txtCadena.Text;
            string[] subs = myString.Split(' ', '.');

            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
                this.listBox1Lista.Items.Add(sub.ToString());
                this.listBox1Lista2.Items.Add(sub.Length.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listBox1Lista.Items.Clear();
            listBox1Lista2.Items.Clear();
        }
    }
}
