using PasswordManager.Entity;
using PasswordManager.Helper;
using System;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class EntryForm : Form
    {
        public Entry Entry;
        private Entry initEntry;

        public EntryForm(Entry entry = null)
        {
            InitializeComponent();

            if (entry != null)
            {
                Entry = entry;
            }
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

        private void OnFormLoad(object sender, EventArgs e)
        {
            tbxTitle.Select();

            if (Entry != null)
            {
                initEntry = (Entry)Entry.Clone();

                tbxTitle.DataBindings.Add("Text", Entry, "Title");
                tbxUsername.DataBindings.Add("Text", Entry, "Username");
                tbxPassword.DataBindings.Add("Text", Entry, "Password");
                tbxConfirm.Text = tbxPassword.Text;
                tbxLink.DataBindings.Add("Text", Entry, "Link");
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (Entry is not null && DialogResult == DialogResult.Cancel)
            {
                Entry.Title = initEntry.Title;
                Entry.Username = initEntry.Username;
                Entry.Password = initEntry.Password;
                Entry.Link = initEntry.Link;
            }
        }
    }
}
