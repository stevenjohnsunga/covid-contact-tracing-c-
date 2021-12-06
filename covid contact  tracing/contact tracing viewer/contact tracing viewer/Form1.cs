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
namespace contact_tracing_viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "txt Files (*.txt) | *.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                richTextBox1.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + "        to view record, click on open file then select the textfile.";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + "        to view record, click on open file then select the textfile.";
        }
    }
}
