using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pubs_DB_App.Publishers;

namespace Pubs_DB_App
{
    public partial class Start_Window : Form
    {
        public Start_Window()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Publisher_Window pubwindow = new Publisher_Window();
            // pubwindow.Show();
            Insert_Window_Employee iwe = new Insert_Window_Employee();
            iwe.Show();
        }
    }
}
