using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Francisco
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void agregaringrediente_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void cocinar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
