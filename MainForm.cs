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

            FormClosing += OnFormClosing;
            Load += OnFormLoad;
            Shown += OnFormShown;
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            if (configuration.LastUsedFile is not null)
            {
                OpenDatabaseForm openDatabaseForm = new OpenDatabaseForm(configuration.LastUsedFile);

                if (openDatabaseForm.ShowDialog(this) == DialogResult.OK)
                {
                    DtgEntries.DataSource = Database.Entries;
                    Text = $"MyPasswordManager - {Path.GetFileName(configuration.LastUsedFile)}";
                }
            }
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            configuration = ConfigurationHelper.LoadConfiguration();
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

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            ConfigurationHelper.SaveConfiguration(configuration);
        }

        private void AddEntry(object sender, EventArgs e)
        {
            EntryForm entryForm = new();

            if (entryForm.ShowDialog(this) == DialogResult.OK)
            {
                Database.Entries.Add(entryForm.Entry);
                DatabaseHelper.SaveDatabase(configuration.LastUsedFile, Database);
            }
        }
    }
}
