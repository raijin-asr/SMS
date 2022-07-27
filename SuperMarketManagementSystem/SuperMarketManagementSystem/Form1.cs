using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketManagementSystem
{
    public partial class loginForm : Form
    {
        connector obj = new connector();
        public loginForm()
        {
            InitializeComponent();
        }

         
       connctorForUsertypes abc = new connctorForUsertypes();   
        private void btnLogin_Click(object sender, EventArgs e)
        { 
              DataTable dt = abc.CheackUserLogin(cmbUsetype.Text,txtUsername.Text,txtPassword.Text);
            if (dt.Rows.Count > 0)
            {
                if (cmbUsetype.Text =="Admin")
                {
                    usertypedetails a = new usertypedetails();
                    a.Show();
                    
                    
                    this.Hide();
                }
                else if(cmbUsetype.Text =="User")
                {
                    MangeProduct b= new MangeProduct();
                    b.Show();
                    this.Hide();

                }


            }
            else
            {
                MessageBox.Show("invalid Username and Password!!!");
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbUsetype.SelectedIndex = 0;
            txtUsername.Focus();
        }

    }
}
