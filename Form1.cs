using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Realistic_RP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Select();
        }
        public DateTime thisDay = DateTime.Today;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TokenFOCUS(object sender, EventArgs e)
        {
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void FileNameFOCUS(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void DateChange(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            string FileSavePath = folderBrowserDialog1.SelectedPath;
            string FileName = textBox2.Text;
            string StrDate = thisDay.ToString("d");
            FileName = FileName + "-" + StrDate;
            string Path = FileSavePath + @"\" + FileName +".RP";

            //Get Text
            string SaveText = richTextBox1.Text;
            File.WriteAllText(Path, SaveText);
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Save File";
            openFileDialog1.ShowDialog();
            string OpenPath = openFileDialog1.FileName.ToString();
            string LoadText = File.ReadAllText(OpenPath);
            richTextBox1.Text = LoadText;
        }
    }
}
