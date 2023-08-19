using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser_NumericUpDown
{
    public partial class Form1 : Form
    {
        void xabar()
        {
            MessageBox.Show("Bu shunchaki chrome 1.0 tez kunda boshqa versiyalari chiqariladi ishlatish uchun url kiriting va qidiring.\n(github.com/sodiqdev2005/)", "Diqqat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public Form1()
        {
            InitializeComponent();
            xabar();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
