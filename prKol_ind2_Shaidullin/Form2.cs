using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prKol_ind2_Shaidullin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String path = dialog.FileName;

                string positive_numbers = "";
                string negotive_numbers = "";


                foreach (string line in File.ReadAllLines(path))
                {
                    try
                    {
                        int value = int.Parse(line);
                        if (value > 0) positive_numbers += $"{value.ToString()}\n";
                        else negotive_numbers += $"{value.ToString()}\n";
                    }
                    catch { continue; }
                }

                positive_label.Text = positive_numbers;
                negotive_label.Text = negotive_numbers;
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
