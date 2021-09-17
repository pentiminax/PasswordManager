using PasswordManager.Entity;
using PasswordManager.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class EntryForm : Form
    {
        public Entry Entry;

        public EntryForm()
        {
            InitializeComponent();
        }

        private void Accept(object sender, EventArgs e)
        {
            if (tbxPassword.Text.Equals(tbxConfirm.Text))
            {
                Entry = new()
                {
                    UUID = Guid.NewGuid().ToString().ToUpper(),
                    Title = tbxTitle.Text,
                    Username = tbxUsername.Text,
                    Password = Security.Encrypt(tbxPassword.Text, ((MainForm)Owner).Database.Hash),
                    Link = tbxLink.Text,
                    CreatedAt = DateTime.Now
                };
            }
            else
            {
                MessageBox.Show("Le mot de passe et sa confirmation ne sont pas identiques.",
                      "La validation a échoué", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
        }

        private void TogglePasswordChar(object sender, EventArgs e)
        {
            tbxPassword.UseSystemPasswordChar = !tbxPassword.UseSystemPasswordChar;
            tbxConfirm.UseSystemPasswordChar = !tbxConfirm.UseSystemPasswordChar;
        }
    }
}
