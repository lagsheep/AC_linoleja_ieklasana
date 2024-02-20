using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AC_linoleja_ieklasana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void gridas_izmaksas(double cena, int plat, int telp_plat, int telp_gar)
        {

            cena = Convert.ToDouble(numericUpDown1.Value);

            plat = Convert.ToInt32(numericUpDown2.Value);

            telp_gar = Convert.ToInt32(numericUpDown3.Value);

            telp_plat = Convert.ToInt32(numericUpDown4.Value);


            int telpas_izmers = telp_gar * telp_plat;
            double izmaksa = cena * telpas_izmers / plat;
          
            textBox1.Text = izmaksa.ToString();


        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) //cena
        {
           

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) //platums
        {
           
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e) //garums
        {

        }

        private void button1_Click(object sender, EventArgs e) //aprekinat
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //izvade
        {

        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
