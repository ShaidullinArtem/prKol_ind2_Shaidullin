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
    public partial class Form1 : Form
    {
        public string vowels = "ауоыиэяюёе";
        public string consonants = "бвгджзйклмнпрстфхцчшщ";

        public Form1()
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

                string vowels_words = "";
                string consonants_words = "";


                foreach (string line in File.ReadAllLines(path))
                {
                   if (Regex.Match(line, @"^[а-яА-Я]+$").Success)
                    {
                        if (vowels.Contains(line[0])) vowels_words += $"{line}\n";
                        if (consonants.Contains(line[0])) consonants_words += $"{line}\n";
                    }
                }

                vowels_label.Text = vowels_words;
                consonants_label.Text = consonants_words;
            }
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
