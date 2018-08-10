using FaceRecognition.Model;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognition.View
{
    public partial class LoginPage : MetroForm
    {
        private DataBase database= new DataBase();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = Uname.Text;
            var password = pasWord.Text;

         bool result=database.CheckUserAuthontication(username,password);

            if (result)
            {
                this.Hide();
                var form2 = new Form1();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else {
                MessageBox.Show("Username and passwoard incorrect");
            }

        }
    }
}
