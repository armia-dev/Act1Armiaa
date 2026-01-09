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

    public void Textbox()
        {   if (Nametxt.Text == "" || Yeartxt.Text == "" || Passtxt.Text == "" || Cnfrmpasstxt.Text == "" || Grouptxt.Text == "" || Invitetxt.Text == "")
            {
                Validlbl.Visible = true;
                Validlbl.Text = "Please fill all the blanks";
            }
                Validlbl.ForeColor = Color.Red;
        }
        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            Year();
            Password();
            Code();
            Textbox();


            }
        
        public void Year()
        {
            Agelbl.Visible = true;
            int year;
            if(!int.TryParse(Yeartxt.Text, out year))
            {
                Agelbl.Text = "Please enter a valid year";
            }
            if (year <= 1900 || year >= 2025)
            {
                Agelbl.Text = "Invalid Birth Year";
            }
            else
            { int age = 2024 - year;
                Agelbl.Text = "Your Age is: " + age.ToString();
            } 
            if (Yeartxt.Text == "")
            {
                Agelbl.Visible = false;
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
            if (Passtxt.Text == "" || Cnfrmpasstxt.Text == "")
            {
                Cnfrmlbl.Visible = false;
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
            if (Grouptxt.Text == "" || Invitetxt.Text == "")
            {
                invitelbl.Visible = false;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
