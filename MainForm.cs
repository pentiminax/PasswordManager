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
        private const int DTG_PASSWORD_COLUMN_INDEX = 2;
        private const int NUMBER_OF_PASSWORD_CHAR = 8;

        public Database Database;

        private Configuration configuration;
        private Entry selectedEntry;

        public MainForm()
        {
            InitializeComponent();

            Database = new();

            Load += OnFormLoad;
            Shown += OnFormShown;
            FormClosing += OnFormClosing;
        }

        #region Form Events
        private void OnFormLoad(object sender, EventArgs e)
        {
            configuration = ConfigurationHelper.LoadConfiguration();

            if (!File.Exists(configuration.LastUsedFile))
            {
                configuration.LastUsedFile = null;
            }
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

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            ConfigurationHelper.SaveConfiguration(configuration);
        }
        #endregion

        #region Entry Methods
        private void AddEntry(object sender, EventArgs e)
        {
            EntryForm entryForm = new();

            if (entryForm.ShowDialog(this) == DialogResult.OK)
            {
                Database.Entries.Add(entryForm.Entry);
                DatabaseHelper.SaveDatabase(configuration.LastUsedFile, Database);
            }
        } 
        #endregion

        #region Database Methods
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

        private void CloseDatabase(object sender, EventArgs e)
        {
            Database = new();
            DtgEntries.DataSource = null;
            Text = "MyPasswordManager";
            configuration.LastUsedFile = null;
        }
        #endregion

        #region Menu Events
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
        #endregion

        #region Methods
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
        #endregion

        #region Copy Methods
        private void CopyUsername(object sender, EventArgs e)
        {
            SetSelectedEntry();

            if (selectedEntry != null)
                Clipboard.SetText(selectedEntry.Username);
        }

        private void CopyPassword(object sender, EventArgs e)
        {
            SetSelectedEntry();

            if (selectedEntry != null)
                Clipboard.SetText(Security.Decrypt(selectedEntry.Password, Database.Hash));
        }
        #endregion

        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DtgEntriesCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == DTG_PASSWORD_COLUMN_INDEX)
            {
                e.Value = new string('*', NUMBER_OF_PASSWORD_CHAR);
            }
        }

        private void EditEntry(object sender, EventArgs e)
        {
            if (DtgEntries.SelectedRows.Count == 1)
            {
                SetSelectedEntry();

                EntryForm entryForm = new(selectedEntry);
                selectedEntry.Password = Security.Decrypt(selectedEntry.Password, Database.Hash);

                if (entryForm.ShowDialog(this) == DialogResult.OK)
                {
                    DtgEntries.RefreshEdit();
                    selectedEntry.Password = Security.Encrypt(selectedEntry.Password, Database.Hash);
                    DatabaseHelper.SaveDatabase(configuration.LastUsedFile, Database);
                }
            }
        }

        private void SetSelectedEntry()
        {
            selectedEntry = (Entry)DtgEntries.CurrentRow.DataBoundItem;
        }
    }
}
