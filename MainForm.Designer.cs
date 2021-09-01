
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNewDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verrouillerLespaceDeTravailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entréeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneEntréeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierLeNomDutilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierLeMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DtgEntries = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.entréeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNewDatabase,
            this.ouvrirToolStripMenuItem,
            this.fermerToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.verrouillerLespaceDeTravailToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // MenuNewDatabase
            // 
            this.MenuNewDatabase.Name = "MenuNewDatabase";
            this.MenuNewDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuNewDatabase.Size = new System.Drawing.Size(263, 22);
            this.MenuNewDatabase.Text = "Nouveau";
            this.MenuNewDatabase.Click += new System.EventHandler(this.NewDatabase);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            // 
            // verrouillerLespaceDeTravailToolStripMenuItem
            // 
            this.verrouillerLespaceDeTravailToolStripMenuItem.Name = "verrouillerLespaceDeTravailToolStripMenuItem";
            this.verrouillerLespaceDeTravailToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.verrouillerLespaceDeTravailToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.verrouillerLespaceDeTravailToolStripMenuItem.Text = "Verrouiller l\'espace de travail";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // entréeToolStripMenuItem
            // 
            this.entréeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneEntréeToolStripMenuItem,
            this.copierLeNomDutilisateurToolStripMenuItem,
            this.copierLeMotDePasseToolStripMenuItem});
            this.entréeToolStripMenuItem.Name = "entréeToolStripMenuItem";
            this.entréeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.entréeToolStripMenuItem.Text = "Entrée";
            // 
            // ajouterUneEntréeToolStripMenuItem
            // 
            this.ajouterUneEntréeToolStripMenuItem.Name = "ajouterUneEntréeToolStripMenuItem";
            this.ajouterUneEntréeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.ajouterUneEntréeToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.ajouterUneEntréeToolStripMenuItem.Text = "Ajouter une entrée";
            this.ajouterUneEntréeToolStripMenuItem.Click += new System.EventHandler(this.AddEntry);
            // 
            // copierLeNomDutilisateurToolStripMenuItem
            // 
            this.copierLeNomDutilisateurToolStripMenuItem.Name = "copierLeNomDutilisateurToolStripMenuItem";
            this.copierLeNomDutilisateurToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.copierLeNomDutilisateurToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.copierLeNomDutilisateurToolStripMenuItem.Text = "Copier le nom  d\'utilisateur";
            // 
            // copierLeMotDePasseToolStripMenuItem
            // 
            this.copierLeMotDePasseToolStripMenuItem.Name = "copierLeMotDePasseToolStripMenuItem";
            this.copierLeMotDePasseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copierLeMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.copierLeMotDePasseToolStripMenuItem.Text = "Copier le mot de passe";
            // 
            // DtgEntries
            // 
            this.DtgEntries.AllowUserToAddRows = false;
            this.DtgEntries.AllowUserToDeleteRows = false;
            this.DtgEntries.AllowUserToResizeRows = false;
            this.DtgEntries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgEntries.BackgroundColor = System.Drawing.Color.White;
            this.DtgEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgEntries.DefaultCellStyle = dataGridViewCellStyle1;
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
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuNewDatabase;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verrouillerLespaceDeTravailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entréeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneEntréeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierLeNomDutilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierLeMotDePasseToolStripMenuItem;
        private System.Windows.Forms.DataGridView DtgEntries;
    }
}

