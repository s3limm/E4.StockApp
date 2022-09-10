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
    public partial class Page_Logined : Form
    {
        public Page_Logined(User _user)
        {
            InitializeComponent();
            user = _user;
        }
        User user;
        private void Page_Logined_Load(object sender, EventArgs e)
        {
          lblWelcome.Text = $"Hoşgeldiniz {user.userName}";
        }
    }
}
