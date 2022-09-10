using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E4.Stock_App
{
    public partial class Form1 : Form
    {
        User user;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user = new User("yavuz", "123");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;

            if (userName == user.userName && passWord == user.password)
            {
                Page_Logined login = new Page_Logined(user);
                login.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Hatalı giriş lütfen tekrar deneyiniz.");
            }

            
        }


    }
}
