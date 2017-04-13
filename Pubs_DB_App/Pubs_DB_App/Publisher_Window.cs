using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pubs_DB_App
{
    public partial class Publisher_Window : Form
    {
        public Publisher_Window()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Insert_Window_Employee iwe = new Insert_Window_Employee();
            iwe.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Insert_Window_Title iwt = new Insert_Window_Title();
            iwt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Insert_Window_Job iwj = new Insert_Window_Job();
            iwj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Insert_Window_Sale iws = new Insert_Window_Sale();
            iws.Show();
        }
    }
}
