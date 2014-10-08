using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Convertor.proxy;

namespace Convertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConverterSoapClient client = new ConverterSoapClient();
            Double output = client.cTof(Convert.ToInt32(textBoxInput.Text));
            sertviceOutput.Text = Convert.ToString(output);
        }

      
    }
}
