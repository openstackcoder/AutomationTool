using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserControlForm
{
    public partial class SelectActionForm : Form
    {
        private TestingRecorder.Browser BrowserValue{get;set;}
        public SelectActionForm(TestingRecorder.Browser browser)
        {
            this.BrowserValue = browser;
            InitializeComponent();
        }

        public SelectActionForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {

            } else
            {
                MessageBox.Show("Please Select a value in Combo Box");
            }
        }
    }
}
