using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W_H_Optimizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void HoursPerMonth_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxHoursPerDay_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculate()
        {
            try
            {
                // numericUpDown_arbeitstageImMonat
                //textbox_arbeitstageImMonat

                //textbox_stundenProTagOffice
                //numericUpDown_stundenProTagOffice

                //textbox_stundenProTagHomeoffice
                //numericUpDown_stundenProTagHomeoffice

                //textbox_GLZAbbauTage
                //numericUpDown__GLZAbbauTage

                //textbox_stundenMonatNachBV
                //numericUpDown__stundenMonatNachBV


                //Hier werden die Stunden die man im Homeoffice machen kann berechnet (173 Stunden pro Monat nach der W@H BV durch 50% Anteil)
                float stundenMonatNachBV = Convert.ToInt32(numericUpDown__stundenMonatNachBV.Text);
                float homeofficeAnteil = Convert.ToInt32(numericUpDown_homeofficeAnteil.Text);

                float stundenProMonatBVHomeoffice = stundenMonatNachBV * (homeofficeAnteil / 100);

                textbox_stundenProMonatBVHomeoffice.Text = stundenProMonatBVHomeoffice.ToString();

                //Hier werden die Stunden im Monat berechnet (Arbeitstage im Monat * 8 Stunden)
                float arbeitstageImMonat = Convert.ToInt32(numericUpDown_arbeitstageImMonat.Text);

                float stundenImMonat = arbeitstageImMonat * 8;

                textbox_stundenImMonat.Text = stundenImMonat.ToString();


                //Hier werden die Tage im Homeoffice berechnet
                float stundenProTagHomeoffice = Convert.ToInt32(numericUpDown_stundenProTagHomeoffice.Text);
                float homeofficeTage = stundenProMonatBVHomeoffice / stundenProTagHomeoffice;

                textBox_homeofficeTage.Text = homeofficeTage.ToString();
                textBox_homeofficeStunden.Text = stundenProTagHomeoffice.ToString();


                //Hier werden die Tage im Office berechnet
                float stundenProTagOffice = Convert.ToInt32(numericUpDown_stundenProTagOffice.Text);
                float officeTage = (stundenImMonat - stundenProMonatBVHomeoffice) / stundenProTagOffice;

                textBox_officeTage.Text = officeTage.ToString();
                textBox_officeStunden.Text = stundenProTagOffice.ToString();



                /*
                 * Hier werden die Abwesenheitstage berechnet (GLZ/Urlaub/sons.) und Feiertage. Es werden zuerst die Office-Tage gekürzt, 
                 * erst danach auch die W@H Tage (z.B. längerer Urlaub). Danach werden die Tage im Office und Homeoffice angepasst.
                

                float abwesenheitsTage = Convert.ToInt32(numericUpDown__GLZAbbauUrlaubTage.Text);
                float feierTage = Convert.ToInt32(numericUpDown1_feiertage.Text);

                float officeTageInklAbwesenheiten;
                float homeofficeTageInklAbwesenheiten;

                if (abwesenheitsTage>0)
                {
                    officeTageInklAbwesenheiten = officeTage - abwesenheitsTage;

                    if(officeTageInklAbwesenheiten<1)
                    {
                        homeofficeTageInklAbwesenheiten = homeofficeTage + officeTageInklAbwesenheiten;
                    }
                }

                textBox_totalHomeofficeTage.Text = homeofficeTageInklAbwesenheiten.ToString();
                textBox_totalOfficeTage.Text = officeTageInklAbwesenheiten.ToString();
                */

                //Hier wird der effektiver W@H Anteil im % berechnet
                //float effektivHomeofficeAnteil = (officeTage/homeofficeTage) * 100;
                float effektivHomeofficeAnteil = homeofficeTage / (officeTage + homeofficeTage) * 100;
                textbox_effektivHomeofficeAnteil.Text = effektivHomeofficeAnteil.ToString();


                /*
                float totalHours = Convert.ToInt32(textbox_HoursPerMonth.Text);
                float maxHoursPerDay = Convert.ToInt32(textbox_HoursPerDayOffice.Text);
                float minHoursPerDay = Convert.ToInt32(textbox_HoursPerDayHomeoffice.Text);

                float homeofficePercentage = Convert.ToInt32(textbox_homeofficeAnteil.Text);

                float homeofficeRatio = homeofficePercentage / 100;

                float totalWorkingDays = totalHours / maxHoursPerDay;

                float officeWorkingDays = totalWorkingDays / homeofficeRatio;
                float homeWorkingDays = (totalWorkingDays - officeWorkingDays);

                float OfficeHours = totalHours / homeofficeRatio;
                float OfficeDays = OfficeHours / maxHoursPerDay;

                float HomeofficeHours = totalHours / homeofficeRatio;
                float HomeofficeDays = HomeofficeHours / minHoursPerDay;

                textBox_homeofficeTage.Text = HomeofficeDays.ToString();

                textBox_arbeitsTageMonat.Text = totalWorkingDays.ToString();
                textBox_officeTage.Text = officeWorkingDays.ToString();

                */

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_WorkingDaysMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox_officeTage_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_GLZAbbauTage_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("W@H Optimizer V. 0.2", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InfoForm.ShowAboutForm();
            
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void textbox_stundenImMonat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_effektivHomeofficeAnteil_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void numericUpDown__GLZAbbauTage_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
