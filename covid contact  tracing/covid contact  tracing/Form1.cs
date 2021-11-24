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

namespace covid_contact__tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string my_q;
        string[] ch_arr = new string[5];

        void cmbADD()
        {
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            comboBox1.Items.Add("others");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbADD();
            radioButton1.Checked = false;
            textBox1.Focus();
            this.ActiveControl = textBox1;
            for (int i = 0; i < 4; i++)
            {
                ch_arr[i] = "";
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                ch_arr[0] = "fever";
            }
            else
            {
                ch_arr[0] = "";
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Items.Clear();
            cmbADD();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            this.ActiveControl = textBox1;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                button1.PerformClick();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("fill in all the fields", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("no answer on question #1", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StreamWriter sw = new StreamWriter(@"db.txt");
                sw.WriteLine("Name: " + textBox1.Text);
                sw.WriteLine("Age: " + textBox2.Text);
                sw.WriteLine("Contact: " + textBox3.Text);
                sw.WriteLine("Gender: " + comboBox1.SelectedItem);
                sw.WriteLine("Have you traveled outside the country anytime from August 2021 until now? " + my_q);

                if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false)
                {
                    sw.WriteLine("Symptoms: none");
                }
                else
                {
                    sw.WriteLine("Symptoms:");
                    int i;
                    for (i = 0; i < 4; i++)
                    {
                        if (ch_arr[i] != "")
                        {
                            sw.WriteLine(ch_arr[i]);
                        }
                    }
                }
                sw.Close();
                MessageBox.Show("Datas are submitted.", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                my_q = "yes";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                my_q = "yes";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                ch_arr[1] = "cough";
            }
            else
            {
                ch_arr[1] = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                ch_arr[2] = "headache";
            }
            else
            {
                ch_arr[2] = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                ch_arr[3] = "hard in breathing";
            }
            else
            {
                ch_arr[3] = "";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                ch_arr[4] = "cold";
            }
            else
            {
                ch_arr[4] = "";
            }
        }
    }
}
