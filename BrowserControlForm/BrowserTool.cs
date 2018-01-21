using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingRecorder;

namespace BrowserControlForm
{
    public partial class BrowserTool : Form
    {
        public Browser CurrentBrowserData { get; set; }

        public BrowserTool()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
            CurrentBrowserData = new Browser();
        }


        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
          
        }

        void Document_Click(object sender, HtmlElementEventArgs e)
        {
            // Assign the selected object to property grid
            var selectedObject = ((HtmlDocument)sender).ActiveElement;
            CurrentBrowserData.BrowserActions.Add(new ControlAction(selectedObject));
            SelectActionForm actionForm = new SelectActionForm(this.CurrentBrowserData);
            actionForm.ShowDialog();
            webBrowser1.Document.Click-= this.Document_Click;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // add a handler for Click event
            webBrowser1.Document.Click += new HtmlElementEventHandler(this.Document_Click);
        }
    }
}
