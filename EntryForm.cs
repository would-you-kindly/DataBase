using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBase
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            if (Identification.Entry(tbLogin.Text, tbPassword.Text))
            {
                Control.currentUser = Control.container.Users.Find(Control.container.Users.
                    Where(x => x.Name == tbLogin.Text).First().Id);
                UserAccountForm userAccountForm = new UserAccountForm();
                userAccountForm.ShowDialog();
            }
        }
    }
}
