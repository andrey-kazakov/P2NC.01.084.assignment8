using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment8_AndreiKazakov
{
    public partial class Form1 : Form
    {
        private LineInFileChecker checker1;
        private LineInFileChecker checker2;
        public Form1()
        {
            InitializeComponent();

            checker1 = new LineInFileChecker();
            checker2 = new LineInFileChecker();
        }

        private void SelectFileButton1_Click(object sender, EventArgs e)
        {
            string path = checker1.SelectAndReadFile();
            if (path == null) return;

            SelectFileButton1.Visible = false;
            FileNameLabel1.Text = path;
            FileNameLabel1.Visible = true;

            StringTextBox1.Enabled = true;
            CheckButton1.Enabled = true;
        }

        private void SelectFileButton2_Click(object sender, EventArgs e)
        {
            string path = checker2.SelectAndReadFile();
            if (path == null) return;

            SelectFileButton2.Visible = false;
            FileNameLabel2.Text = path;
            FileNameLabel2.Visible = true;

            StringTextBox2.Enabled = true;
            CheckButton2.Enabled = true;
        }

        private void CheckButton1_Click(object sender, EventArgs e)
        {
            DisplayResult(checker1.CheckLine(StringTextBox1.Text));
        }

        private void CheckButton2_Click(object sender, EventArgs e)
        {
            DisplayResult(checker2.CheckLine(StringTextBox2.Text));
        }

        private void DisplayResult(bool result)
        {
            if (result)
            {
                MessageBox.Show("The line is present in the file", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The line is not present in the file", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
