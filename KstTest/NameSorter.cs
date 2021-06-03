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
        private string UnsortedNames;
        private string SortedNames;

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
                UnsortedNames = Jobs.ReadNamesText();
                TextBoxUnsorted.Text = UnsortedNames;
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
                SortedNames = Jobs.SortNamesText();
                TextBoxSorted.Text = SortedNames;
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
            object s = "ReadSort";
            EventArgs t = null;
            ButtonRead_Click(s, t);
            ButtonSort_Click(s, t);
            ButtonSave_Click(s, t);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnsortedNames = "";
            SortedNames = "";
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
