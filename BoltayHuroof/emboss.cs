using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoltayHuroof
{
    public partial class emboss : Form
    {
        string source;
        public emboss(string sourceText)
        {
            InitializeComponent();
            this.source = sourceText;
        }

        public emboss()
        {
            InitializeComponent();
        }

        private void emboss_Load(object sender, EventArgs e)
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                emobossers_list.Items.Add(printer);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RawHelper.SendStringToPrinter(emobossers_list.Text, source);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
