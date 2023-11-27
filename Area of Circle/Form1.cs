using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_of_Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Area_Click(object sender, EventArgs e)
        {
            float area;
            area = (float)Math.PI * float.Parse(radius.Text) * float.Parse(radius.Text);
            areatotal.Text = area.ToString();
        }
    }
}
