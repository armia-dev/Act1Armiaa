using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act1Armia
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            Year();
            Password();
            Code();
        }
        public void Year()
        {
            Agelbl.Visible = true;
            int year; 
            year = Convert.ToInt32(Yeartxt.Text);
            if (year <= 1900 || year >= 2025)
            {
                Agelbl.Text = "Year is out of range";
            }
            else
            { int age = 2024 - year;
                Agelbl.Text = "Your Age is: " + age.ToString();
            }
            

        }

        public void Password()
        {
            Cnfrmlbl.Visible= true;
            if (Passtxt.Text == Cnfrmpasstxt.Text)
            {
                Cnfrmlbl.Text = "Accepted";

            }
            else
            {
                Cnfrmlbl.Text = "Password does not match";
            }
        }
        public void Code()
        {
            invitelbl.Visible = true;
            if (Grouptxt.Text == "UCC2025" && Invitetxt.Text == "PROMO1225" || Invitetxt.Text == "PROMO2025")
            {
                invitelbl.Text = "Accepted";
            }
            else
            {
                invitelbl.Text = "Code does not match";
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
