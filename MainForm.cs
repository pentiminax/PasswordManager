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

            Database = new();

            FormClosing += OnFormClosing;
            Load += OnFormLoad;
            Shown += OnFormShown;
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            if (configuration.LastUsedFile is not null)
            {
                OpenDatabaseForm openDatabaseForm = new(configuration.LastUsedFile);

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

            if (!File.Exists(configuration.LastUsedFile))
            {
                configuration.LastUsedFile = null;
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            ConfigurationHelper.SaveConfiguration(configuration);
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

        private void OpenDatabase(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();

            if (ofd.ShowDialog() == DialogResult.OK)
                OpenDatabaseForm(ofd.FileName);
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

        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseDatabase(object sender, EventArgs e)
        {
            Database = new();
            DtgEntries.DataSource = null;
            Text = "MyPasswordManager";
            configuration.LastUsedFile = null;
        }

        private void SaveDatabase(object sender, EventArgs e)
        {
            DatabaseHelper.SaveDatabase(configuration.LastUsedFile, Database);
        }

        private void LockDatabase(object sender, EventArgs e)
        {
            Database = new();
            DtgEntries.DataSource = null;
            Text = "MyPasswordManager";
            OpenDatabaseForm(configuration.LastUsedFile);
        }

        private void OpenDatabaseForm(string dbFile)
        {
            OpenDatabaseForm openDatabaseForm = new(dbFile);

            if (openDatabaseForm.ShowDialog(this) == DialogResult.OK)
            {
                DtgEntries.DataSource = Database.Entries;
                Text = $"MyPasswordManager - {Path.GetFileName(dbFile)}";
                configuration.LastUsedFile = dbFile;
            }
        }

        private void MenuFileOpening(object sender, EventArgs e)
        {
            if (Database.Hash is not null)
                ToggleFileMenu(isEnabled: true);
            else
                ToggleFileMenu(isEnabled: false);
        }

        private void MenuEntryOpening(object sender, EventArgs e)
        {
            if (Database.Hash is not null)
                ToggleEntryMenu(isEnabled: true);
            else
                ToggleEntryMenu(isEnabled: false);
        }

        private void ToggleFileMenu(bool isEnabled)
        {
            menuSaveDatabase.Enabled = isEnabled;
            menuCloseDatabase.Enabled = isEnabled;
            menuLockDatabase.Enabled = isEnabled;
        }

        private void ToggleEntryMenu(bool isEnabled)
        {
            menuAddEntry.Enabled = isEnabled;
            menuCopyUsername.Enabled = isEnabled;
            menuCopyPassword.Enabled = isEnabled;
        }
    }
}
