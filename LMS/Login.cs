using LMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new LmsContext())
            {
                var name = txtName.Text;
                var pass = txtPassword.Text;

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var user = context.Staff.Where(u => u.Name.ToLower() == name.ToLower()).Join(context.AuthenticationSystems,
                    staff => staff.LoginId,
                    auth => auth.LoginId,
                    (s, a) => new { name = s.Name, password = a.Password }).FirstOrDefault();

                if (user != null && user.password == pass)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect name or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPass.Checked) {
                txtPassword.PasswordChar=default;
            }
            else
            {
                txtPassword.PasswordChar='*';
            }
        }
    }
}
