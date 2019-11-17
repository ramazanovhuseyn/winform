using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.login = txbx_login.Text;
            user.password = txbx_password.Text;
            user.userName = txbx_username.Text;

            if (!(string.IsNullOrWhiteSpace(user.login) || string.IsNullOrWhiteSpace(user.password) || string.IsNullOrWhiteSpace(user.userName)))
            {
                DataBase.addUser(user);
                MessageBox.Show("qeydiyyat ugurla basha catdi!");
                Close();
            }
            else
            {
                MessageBox.Show("xana boshdur!");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbx_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbx_login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
