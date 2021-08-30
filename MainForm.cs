using PasswordManager.Entity;
using PasswordManager.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class MainForm : Form
    {
        public Database Database;

        private Configuration configuration;

        public MainForm()
        {
            InitializeComponent();
            Database = new Database();
            configuration = new Configuration();
        }

        private void NewDatabase(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new();
            sfd.FileName = "Base de données.mpm";
            sfd.Filter = "Fichier MPM de MyPasswordManager | *.mpm";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var dbFile = sfd.FileName;
                NewDatabaseForm newDatabaseForm = new();

                if (newDatabaseForm.ShowDialog(this) == DialogResult.OK)
                {
                    Database.Entries = new BindingList<Entry>();
                    DtgEntries.DataSource = Database.Entries;
                    configuration.LastUsedFile = dbFile;

                    DatabaseHelper.SaveDatabase(dbFile, Database);

                    Text = $"MyPasswordManager - {Path.GetFileName(dbFile)}";
                }
            }
        }
    }
}
