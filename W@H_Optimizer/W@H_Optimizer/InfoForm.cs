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

namespace W_H_Optimizer
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        // Add a public method to set the text of the TextBox control
        public void SetChangelogText(string filePath)
        {
            try
            {
                // Read the text from the file and set it as the text of the TextBox control
                string text = File.ReadAllText(filePath);
                textBox2.Text = text;
            }
            catch (Exception ex)
            {
                // If an error occurs, display a message box with the error message
                MessageBox.Show("Error loading changelog: " + ex.Message);
            }
        }

        public void SetHelpText(string filePath)
        {
            try
            {
                // Read the text from the file and set it as the text of the TextBox control
                string text = File.ReadAllText(filePath);
                textBox1.Text = text;
            }
            catch (Exception ex)
            {
                // If an error occurs, display a message box with the error message
                MessageBox.Show("Error loading changelog: " + ex.Message);
            }
        }



        public static void ShowAboutForm()
        {
            InfoForm infoForm = new InfoForm();
            infoForm.SetChangelogText("changelog.txt");
            infoForm.SetHelpText("help.txt");
            infoForm.ShowDialog();
            
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
