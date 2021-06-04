using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KstTest.Class;

namespace KstTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonSort.Enabled = false;
            ButtonSave.Enabled = false;
        }

        private void ButtonRead_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxUnsorted.Text = Jobs.ReadNamesText();
                ButtonSort.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("File Not Found!");
            }
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            try
            {
                TextBoxSorted.Text = Jobs.SortNamesText();
                ButtonRead.Enabled = false;
                ButtonReadSort.Enabled = false;
                ButtonSave.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error While Sorting!");
            }

        }

        private void ButtonReadSort_Click(object sender, EventArgs e)
        {
            try
            {
                ButtonRead_Click(sender, e);
                ButtonSort_Click(sender, e);
                ButtonSave_Click(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Error While Processing!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxUnsorted.Clear();
            TextBoxSorted.Clear();
            ButtonRead.Enabled = true;
            ButtonSort.Enabled = false;
            ButtonSave.Enabled = false;
            ButtonReadSort.Enabled = true;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Jobs.WriteNamesText();
                MessageBox.Show("Save To File Succeed!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error While Writing File!");
            }
        }
    }
}
