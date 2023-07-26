﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAdress = emailValue.Text;
                p.CellphoneNumber = phoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                phoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("Fields need filled");
            }
        }

        private bool ValidateForm() 
        {
            if (firstNameValue.Text.Length == 0)
            { 
                return false;
            }if (lastNameValue.Text.Length == 0)
            { 
                return false;
            }if (emailValue.Text.Length == 0)
            { 
                return false;
            }if (phoneValue.Text.Length == 0)
            { 
                return false;
            }

            return true;
        }
    }
}
