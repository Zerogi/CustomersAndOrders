using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Linq;
using System.Windows;

namespace CustomersAndOrders
{
    public partial class RegisterPage : Form
    {
        ApplicationContext db;
        public RegisterPage()
        {
            InitializeComponent();

            db = new ApplicationContext();
            db.User.Load();
            //this.DataContext = db.Users.Local.ToBindingList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                // Get user input
                string fullname = this.FullnameTextBox.Text;
                string phoneNumber = this.PhoneNumberTextBox.Text;
                string address = this.AddressTextBox.Text;
                string email = this.EmailTextBox.Text;
                string password = this.PasswordTextBox.Text;
                // Add to DB.
                User user = new User();
                user.Fullname = fullname;
                user.PhoneNumber = phoneNumber;
                user.Address = address;
                user.Email = email;
                user.Password = password;
                db.User.Add(user);
                db.SaveChanges();
            }
            else
            {

            }
        }

        /// <summary>
        /// Check all fileds for correct input.
        /// </summary>
        /// <returns></returns>
        private bool CheckFields()
        {
            return true;
        }
    }
}
