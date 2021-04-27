using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frm_Add_Employee_Details_3
{
    public partial class Frm_Login_Page : Form
    {
        public Frm_Login_Page()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

            if (tb_username.Text == "A1" && tb_password.Text == "A")
            {
                MessageBox.Show("Login Succesfully...");
            }

            else
            {
                lbl_note.Text = "Please Enter Valid Details";
                lbl_note.ForeColor = Color.Red;
            }
        }
    }
}
