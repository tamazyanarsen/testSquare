using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testSquare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var v1 = textBox1.Text;
            var v2 = textBox2.Text;
            var v3 = textBox3.Text;
            if(v2.Length > 0 && v3.Length > 0)
            {
                label1.Text = "sdf";// здесь посчитаешь площадь
            }
            else
            {
                label1.Text = (Math.PI * Convert.ToDouble(v1) * Convert.ToDouble(v1)).ToString();
            }
        }
    }
}
