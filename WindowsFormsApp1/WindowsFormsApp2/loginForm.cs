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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
           if( DataBase.checkUser(txbx_l.Text, txbx_p.Text))
            {
                ticketForm ticketForm = new ticketForm();
                ticketForm.ShowDialog();
            }
           else if(string.IsNullOrWhiteSpace( txbx_l.Text )|| string.IsNullOrWhiteSpace(txbx_p.Text))
            {
                MessageBox.Show("xana bosh ola bilmez!!");
            }
            else
            {
                MessageBox.Show("login ve ya password yalnisdir!");
            }
        }
    }
}
