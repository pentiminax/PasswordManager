
namespace PasswordManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLockDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopyUsername = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopyPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.DtgEntries = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEntry});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewDatabase,
            this.menuOpenDatabase,
            this.menuCloseDatabase,
            this.menuSaveDatabase,
            this.menuLockDatabase,
            this.menuExitApplication});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(54, 20);
            this.menuFile.Text = "Fichier";
            this.menuFile.DropDownOpening += new System.EventHandler(this.MenuFileOpening);
            // 
            // menuNewDatabase
            // 
            this.menuNewDatabase.Name = "menuNewDatabase";
            this.menuNewDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNewDatabase.Size = new System.Drawing.Size(263, 22);
            this.menuNewDatabase.Text = "Nouveau";
            this.menuNewDatabase.Click += new System.EventHandler(this.NewDatabase);
            // 
            // menuOpenDatabase
            // 
            this.menuOpenDatabase.Name = "menuOpenDatabase";
            this.menuOpenDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpenDatabase.Size = new System.Drawing.Size(263, 22);
            this.menuOpenDatabase.Text = "Ouvrir";
            this.menuOpenDatabase.Click += new System.EventHandler(this.OpenDatabase);
            // 
            // menuCloseDatabase
            // 
            this.menuCloseDatabase.Name = "menuCloseDatabase";
            this.menuCloseDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuCloseDatabase.Size = new System.Drawing.Size(263, 22);
            this.menuCloseDatabase.Text = "Fermer";
            this.menuCloseDatabase.Click += new System.EventHandler(this.CloseDatabase);
            // 
            // menuSaveDatabase
            // 
            this.menuSaveDatabase.Name = "menuSaveDatabase";
            this.menuSaveDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSaveDatabase.Size = new System.Drawing.Size(263, 22);
            this.menuSaveDatabase.Text = "Enregistrer";
            this.menuSaveDatabase.Click += new System.EventHandler(this.SaveDatabase);
            // 
            // menuLockDatabase
            // 
            this.menuLockDatabase.Name = "menuLockDatabase";
            this.menuLockDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menuLockDatabase.Size = new System.Drawing.Size(263, 22);
            this.menuLockDatabase.Text = "Verrouiller l\'espace de travail";
            this.menuLockDatabase.Click += new System.EventHandler(this.LockDatabase);
            // 
            // menuExitApplication
            // 
            this.menuExitApplication.Name = "menuExitApplication";
            this.menuExitApplication.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuExitApplication.Size = new System.Drawing.Size(263, 22);
            this.menuExitApplication.Text = "Quitter";
            this.menuExitApplication.Click += new System.EventHandler(this.ExitApplication);
            // 
            // menuEntry
            // 
            this.menuEntry.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddEntry,
            this.menuCopyUsername,
            this.menuCopyPassword});
            this.menuEntry.Name = "menuEntry";
            this.menuEntry.Size = new System.Drawing.Size(52, 20);
            this.menuEntry.Text = "Entrée";
            this.menuEntry.DropDownOpening += new System.EventHandler(this.MenuEntryOpening);
            // 
            // menuAddEntry
            // 
            this.menuAddEntry.Name = "menuAddEntry";
            this.menuAddEntry.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.menuAddEntry.Size = new System.Drawing.Size(258, 22);
            this.menuAddEntry.Text = "Ajouter une entrée";
            this.menuAddEntry.Click += new System.EventHandler(this.AddEntry);
            // 
            // menuCopyUsername
            // 
            this.menuCopyUsername.Name = "menuCopyUsername";
            this.menuCopyUsername.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menuCopyUsername.Size = new System.Drawing.Size(258, 22);
            this.menuCopyUsername.Text = "Copier le nom  d\'utilisateur";
            // 
            // menuCopyPassword
            // 
            this.menuCopyPassword.Name = "menuCopyPassword";
            this.menuCopyPassword.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuCopyPassword.Size = new System.Drawing.Size(258, 22);
            this.menuCopyPassword.Text = "Copier le mot de passe";
            // 
            // DtgEntries
            // 
            this.DtgEntries.AllowUserToAddRows = false;
            this.DtgEntries.AllowUserToDeleteRows = false;
            this.DtgEntries.AllowUserToResizeRows = false;
            this.DtgEntries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgEntries.BackgroundColor = System.Drawing.Color.White;
            this.DtgEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgEntries.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtgEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgEntries.Location = new System.Drawing.Point(0, 24);
            this.DtgEntries.Name = "DtgEntries";
            this.DtgEntries.ReadOnly = true;
            this.DtgEntries.RowTemplate.Height = 25;
            this.DtgEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgEntries.ShowCellToolTips = false;
            this.DtgEntries.ShowEditingIcon = false;
            this.DtgEntries.Size = new System.Drawing.Size(784, 537);
            this.DtgEntries.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.DtgEntries);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPasswordManager";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNewDatabase;
        private System.Windows.Forms.ToolStripMenuItem menuOpenDatabase;
        private System.Windows.Forms.ToolStripMenuItem menuCloseDatabase;
        private System.Windows.Forms.ToolStripMenuItem menuSaveDatabase;
        private System.Windows.Forms.ToolStripMenuItem menuLockDatabase;
        private System.Windows.Forms.ToolStripMenuItem menuExitApplication;
        private System.Windows.Forms.ToolStripMenuItem menuEntry;
        private System.Windows.Forms.ToolStripMenuItem menuAddEntry;
        private System.Windows.Forms.ToolStripMenuItem menuCopyUsername;
        private System.Windows.Forms.ToolStripMenuItem menuCopyPassword;
        private System.Windows.Forms.DataGridView DtgEntries;
    }
}

