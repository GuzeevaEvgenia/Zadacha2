using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha2
{
    public partial class Form1 : Form
    {
        FirstClass fc;
        public Form1()
        {
            InitializeComponent();
        }
        private void But_Add_Click(object sender, EventArgs e)
        {
            fc = new FirstClass(TB_Type.Text, Convert.ToInt32(TB_cableCores.Text), Convert.ToInt32(TB_diameter.Text));
        }

        private void But_Show_1_Click(object sender, EventArgs e)
        {
            fc.Quality();
            TB_Result.Text = fc.ShowInf();
        }

        private void But_Show_2_Click(object sender, EventArgs e)
        {
            fc = new SecondClass(TB_Type.Text, Convert.ToInt32(TB_cableCores.Text), Convert.ToInt32(TB_diameter.Text), false);
            fc.Quality();
            TB_Result.Text = fc.ShowInf();
        }
    }
}
    

