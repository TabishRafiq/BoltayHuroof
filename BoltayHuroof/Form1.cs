using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoltayHuroof
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> codes = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();

            codes.Add(" ", " ");
            codes.Add("#", "#");
            codes.Add(".", "4");
            codes.Add("?", "8");
            codes.Add("!", "6");

            codes.Add("ا", "a");
            codes.Add("آ", ">");
            codes.Add("ب", "b");
            codes.Add("پ", "p");
            codes.Add("ت", "t");
            codes.Add("ٹ", "[");
            codes.Add("ث", "?");
            codes.Add("ج", "j");
            codes.Add("چ", "c");
            codes.Add("ح", ":");
            codes.Add("خ", "x");
            codes.Add("د", "d");
            codes.Add("ڈ", "+");
            codes.Add("ذ", "!");
            codes.Add("ر", "r");
            codes.Add("ڑ", "]");
            codes.Add("ز", "z");
            codes.Add("ژ", "\"z");
            codes.Add("س", "s");
            codes.Add("ش", "%");
            codes.Add("ص", "&");
            codes.Add("ض", "$");
            codes.Add("ط", ")");
            codes.Add("ظ", "=");
            codes.Add("ع", "(");
            codes.Add("غ", "<");
            codes.Add("ف", "f");
            codes.Add("ق", "q");
            codes.Add("ک", "k");
            codes.Add("گ", "g");
            codes.Add("ل", "l");
            codes.Add("م", "m");
            codes.Add("ن", "n");
            codes.Add("ں", ";");
            codes.Add("و", "w");
            codes.Add("ؤ", "\\");
            codes.Add("ہ", "h");
            codes.Add("ھ", "8");
            codes.Add("ء", "'");
            codes.Add("ئ", "'");
            codes.Add("ی", "i");
            codes.Add("ے", "/");
            codes.Add("ۓ", "/");
            codes.Add("ِ", "e");
            codes.Add("َ", "1");
            codes.Add("ُ", "u");
            codes.Add("ٰ", "o");
            codes.Add("ّ", ",");
            codes.Add("ً", ",");

            codes.Add("١", "a");
            codes.Add("٢", "b");
            codes.Add("٣", "c");
            codes.Add("٤", "d");
            codes.Add("٥", "e");
            codes.Add("٦", "f");
            codes.Add("٧", "g");
            codes.Add("٨", "h");
            codes.Add("٩", "i");
            codes.Add("٠", "j");

            codes.Add("1", "a");
            codes.Add("2", "b");
            codes.Add("3", "c");
            codes.Add("4", "d");
            codes.Add("5", "e");
            codes.Add("6", "f");
            codes.Add("7", "g");
            codes.Add("8", "h");
            codes.Add("9", "i");
            codes.Add("0", "j");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void translateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = souText.Text;
            text = Regex.Replace(text, @"(\d+)", "#$1");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                
                sb.Append(codes[text[i].ToString()]);
            }
            desText.Text = sb.ToString();
        }

        private void embossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emboss emboss = new emboss(desText.Text);
            emboss.ShowDialog();
        }
    }
}
