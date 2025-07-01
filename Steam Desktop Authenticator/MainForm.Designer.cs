namespace Steam_Desktop_Authenticator
{

    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnSteamLogin = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnCopy = new System.Windows.Forms.Button();
            pbTimeout = new System.Windows.Forms.ProgressBar();
            txtLoginToken = new System.Windows.Forms.TextBox();
            listAccounts = new System.Windows.Forms.ListBox();
            timerSteamGuard = new System.Windows.Forms.Timer(components);
            btnTradeConfirmations = new System.Windows.Forms.Button();
            btnManageEncryption = new System.Windows.Forms.Button();
            groupAccount = new System.Windows.Forms.GroupBox();
            menuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuImportAccount = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuLoginAgain = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            menuRemoveAccountFromManifest = new System.Windows.Forms.ToolStripMenuItem();
            menuDeactivateAuthenticator = new System.Windows.Forms.ToolStripMenuItem();
            trayIcon = new System.Windows.Forms.NotifyIcon(components);
            menuStripTray = new System.Windows.Forms.ContextMenuStrip(components);
            trayRestore = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            trayAccountList = new System.Windows.Forms.ToolStripComboBox();
            trayTradeConfirmations = new System.Windows.Forms.ToolStripMenuItem();
            trayCopySteamGuard = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            trayQuit = new System.Windows.Forms.ToolStripMenuItem();
            timerTradesPopup = new System.Windows.Forms.Timer(components);
            lblStatus = new System.Windows.Forms.Label();
            txtAccSearch = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panelButtons = new System.Windows.Forms.Panel();
            labelVersion = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupAccount.SuspendLayout();
            menuStrip.SuspendLayout();
            menuStripTray.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // btnSteamLogin
            // 
            btnSteamLogin.Location = new System.Drawing.Point(0, 0);
            btnSteamLogin.Name = "btnSteamLogin";
            btnSteamLogin.Size = new System.Drawing.Size(124, 30);
            btnSteamLogin.TabIndex = 1;
            btnSteamLogin.Text = "Добавить аккаунт";
            btnSteamLogin.UseVisualStyleBackColor = true;
            btnSteamLogin.Click += btnSteamLogin_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(btnCopy);
            groupBox1.Controls.Add(pbTimeout);
            groupBox1.Controls.Add(txtLoginToken);
            groupBox1.Location = new System.Drawing.Point(12, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(310, 85);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Код для входа";
            // 
            // btnCopy
            // 
            btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCopy.Image = Properties.Resources.iconcopy;
            btnCopy.Location = new System.Drawing.Point(269, 19);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new System.Drawing.Size(35, 35);
            btnCopy.TabIndex = 2;
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // pbTimeout
            // 
            pbTimeout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pbTimeout.Location = new System.Drawing.Point(6, 60);
            pbTimeout.Maximum = 30;
            pbTimeout.Name = "pbTimeout";
            pbTimeout.Size = new System.Drawing.Size(298, 19);
            pbTimeout.TabIndex = 1;
            pbTimeout.Value = 30;
            // 
            // txtLoginToken
            // 
            txtLoginToken.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLoginToken.BackColor = System.Drawing.SystemColors.Window;
            txtLoginToken.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtLoginToken.Location = new System.Drawing.Point(6, 19);
            txtLoginToken.Name = "txtLoginToken";
            txtLoginToken.ReadOnly = true;
            txtLoginToken.Size = new System.Drawing.Size(257, 35);
            txtLoginToken.TabIndex = 0;
            txtLoginToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listAccounts
            // 
            listAccounts.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listAccounts.FormattingEnabled = true;
            listAccounts.ItemHeight = 13;
            listAccounts.Location = new System.Drawing.Point(12, 217);
            listAccounts.Name = "listAccounts";
            listAccounts.Size = new System.Drawing.Size(310, 186);
            listAccounts.TabIndex = 3;
            listAccounts.SelectedValueChanged += listAccounts_SelectedValueChanged;
            listAccounts.KeyDown += listAccounts_KeyDown;
            // 
            // timerSteamGuard
            // 
            timerSteamGuard.Enabled = true;
            timerSteamGuard.Interval = 1000;
            timerSteamGuard.Tick += timerSteamGuard_Tick;
            // 
            // btnTradeConfirmations
            // 
            btnTradeConfirmations.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnTradeConfirmations.Enabled = false;
            btnTradeConfirmations.Location = new System.Drawing.Point(6, 19);
            btnTradeConfirmations.Name = "btnTradeConfirmations";
            btnTradeConfirmations.Size = new System.Drawing.Size(298, 31);
            btnTradeConfirmations.TabIndex = 4;
            btnTradeConfirmations.Text = "Просмотреть подтверждения";
            btnTradeConfirmations.UseVisualStyleBackColor = true;
            btnTradeConfirmations.Click += btnTradeConfirmations_Click;
            // 
            // btnManageEncryption
            // 
            btnManageEncryption.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnManageEncryption.Location = new System.Drawing.Point(130, 0);
            btnManageEncryption.Name = "btnManageEncryption";
            btnManageEncryption.Size = new System.Drawing.Size(180, 30);
            btnManageEncryption.TabIndex = 6;
            btnManageEncryption.Text = "Управление шифрованием";
            btnManageEncryption.UseVisualStyleBackColor = true;
            btnManageEncryption.Click += btnManageEncryption_Click;
            // 
            // groupAccount
            // 
            groupAccount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupAccount.Controls.Add(btnTradeConfirmations);
            groupAccount.Location = new System.Drawing.Point(12, 155);
            groupAccount.Name = "groupAccount";
            groupAccount.Size = new System.Drawing.Size(310, 56);
            groupAccount.TabIndex = 7;
            groupAccount.TabStop = false;
            groupAccount.Text = "Аккаунт";
            // 
            // menuStrip
            // 
            menuStrip.BackColor = System.Drawing.SystemColors.Control;
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, accountToolStripMenuItem });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new System.Drawing.Size(334, 24);
            menuStrip.TabIndex = 10;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuImportAccount, toolStripSeparator1, menuSettings, menuQuit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // menuImportAccount
            // 
            menuImportAccount.Name = "menuImportAccount";
            menuImportAccount.Size = new System.Drawing.Size(207, 22);
            menuImportAccount.Text = "Импортировать аккаунт";
            menuImportAccount.Click += menuImportAccount_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // menuSettings
            // 
            menuSettings.Name = "menuSettings";
            menuSettings.Size = new System.Drawing.Size(207, 22);
            menuSettings.Text = "Настройки";
            menuSettings.Click += menuSettings_Click;
            // 
            // menuQuit
            // 
            menuQuit.Name = "menuQuit";
            menuQuit.Size = new System.Drawing.Size(207, 22);
            menuQuit.Text = "Выход";
            menuQuit.Click += menuQuit_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuLoginAgain, toolStripSeparator4, menuRemoveAccountFromManifest, menuDeactivateAuthenticator });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            accountToolStripMenuItem.Text = "Аккаунт";
            // 
            // menuLoginAgain
            // 
            menuLoginAgain.Name = "menuLoginAgain";
            menuLoginAgain.Size = new System.Drawing.Size(228, 22);
            menuLoginAgain.Text = "Войти снова";
            menuLoginAgain.Click += menuLoginAgain_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(225, 6);
            // 
            // menuRemoveAccountFromManifest
            // 
            menuRemoveAccountFromManifest.Name = "menuRemoveAccountFromManifest";
            menuRemoveAccountFromManifest.Size = new System.Drawing.Size(228, 22);
            menuRemoveAccountFromManifest.Text = "Удалить";
            menuRemoveAccountFromManifest.Click += menuRemoveAccountFromManifest_Click;
            // 
            // menuDeactivateAuthenticator
            // 
            menuDeactivateAuthenticator.Name = "menuDeactivateAuthenticator";
            menuDeactivateAuthenticator.Size = new System.Drawing.Size(228, 22);
            menuDeactivateAuthenticator.Text = "Отключить аутентификатор";
            menuDeactivateAuthenticator.Click += menuDeactivateAuthenticator_Click;
            // 
            // trayIcon
            // 
            trayIcon.ContextMenuStrip = menuStripTray;
            trayIcon.Text = "Steam Desktop Authenticator";
            trayIcon.Visible = true;
            trayIcon.MouseDoubleClick += trayIcon_MouseDoubleClick;
            // 
            // menuStripTray
            // 
            menuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { trayRestore, toolStripSeparator2, trayAccountList, trayTradeConfirmations, trayCopySteamGuard, toolStripSeparator3, trayQuit });
            menuStripTray.Name = "contextMenuStripTray";
            menuStripTray.Size = new System.Drawing.Size(207, 131);
            // 
            // trayRestore
            // 
            trayRestore.Name = "trayRestore";
            trayRestore.Size = new System.Drawing.Size(206, 22);
            trayRestore.Text = "Восстановить";
            trayRestore.Click += trayRestore_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // trayAccountList
            // 
            trayAccountList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            trayAccountList.Items.AddRange(new object[] { "test1", "test2" });
            trayAccountList.Name = "trayAccountList";
            trayAccountList.Size = new System.Drawing.Size(121, 23);
            trayAccountList.SelectedIndexChanged += trayAccountList_SelectedIndexChanged;
            // 
            // trayTradeConfirmations
            // 
            trayTradeConfirmations.Name = "trayTradeConfirmations";
            trayTradeConfirmations.Size = new System.Drawing.Size(206, 22);
            trayTradeConfirmations.Text = "Подтверждения обмена";
            trayTradeConfirmations.Click += trayTradeConfirmations_Click;
            // 
            // trayCopySteamGuard
            // 
            trayCopySteamGuard.Name = "trayCopySteamGuard";
            trayCopySteamGuard.Size = new System.Drawing.Size(206, 22);
            trayCopySteamGuard.Text = "Копировать код SG";
            trayCopySteamGuard.Click += trayCopySteamGuard_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(203, 6);
            // 
            // trayQuit
            // 
            trayQuit.Name = "trayQuit";
            trayQuit.Size = new System.Drawing.Size(206, 22);
            trayQuit.Text = "Выход";
            trayQuit.Click += trayQuit_Click;
            // 
            // timerTradesPopup
            // 
            timerTradesPopup.Enabled = true;
            timerTradesPopup.Interval = 5000;
            timerTradesPopup.Tick += timerTradesPopup_Tick;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblStatus.BackColor = System.Drawing.SystemColors.Control;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblStatus.Location = new System.Drawing.Point(166, 5);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(163, 18);
            lblStatus.TabIndex = 11;
            lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAccSearch
            // 
            txtAccSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtAccSearch.Location = new System.Drawing.Point(63, 411);
            txtAccSearch.Name = "txtAccSearch";
            txtAccSearch.Size = new System.Drawing.Size(259, 22);
            txtAccSearch.TabIndex = 12;
            txtAccSearch.TextChanged += txtAccSearch_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 416);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 13);
            label1.TabIndex = 13;
            label1.Text = "Фильтр:";
            // 
            // panelButtons
            // 
            panelButtons.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelButtons.BackColor = System.Drawing.Color.Transparent;
            panelButtons.Controls.Add(btnSteamLogin);
            panelButtons.Controls.Add(btnManageEncryption);
            panelButtons.Location = new System.Drawing.Point(12, 26);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new System.Drawing.Size(310, 30);
            panelButtons.TabIndex = 14;
            panelButtons.SizeChanged += panelButtons_SizeChanged;
            // 
            // labelVersion
            // 
            labelVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            labelVersion.BackColor = System.Drawing.Color.Transparent;
            labelVersion.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            labelVersion.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            labelVersion.Location = new System.Drawing.Point(260, 441);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new System.Drawing.Size(70, 15);
            labelVersion.TabIndex = 8;
            labelVersion.Text = "v0.0.1 (G4F)";
            labelVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // MainForm
            // 
            AcceptButton = btnCopy;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(334, 461);
            Controls.Add(panelButtons);
            Controls.Add(label1);
            Controls.Add(txtAccSearch);
            Controls.Add(lblStatus);
            Controls.Add(labelVersion);
            Controls.Add(groupAccount);
            Controls.Add(listAccounts);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip);
            Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            MinimumSize = new System.Drawing.Size(350, 400);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Steam Desktop Authenticator";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            KeyDown += MainForm_KeyDown;
            Resize += MainForm_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupAccount.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            menuStripTray.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnSteamLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar pbTimeout;
        private System.Windows.Forms.TextBox txtLoginToken;
        private System.Windows.Forms.ListBox listAccounts;
        private System.Windows.Forms.Timer timerSteamGuard;
        private System.Windows.Forms.Button btnTradeConfirmations;
        private System.Windows.Forms.Button btnManageEncryption;
        private System.Windows.Forms.GroupBox groupAccount;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRemoveAccountFromManifest;
        private System.Windows.Forms.ToolStripMenuItem menuLoginAgain;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip menuStripTray;
        private System.Windows.Forms.ToolStripMenuItem trayRestore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem trayTradeConfirmations;
        private System.Windows.Forms.ToolStripMenuItem trayCopySteamGuard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem trayQuit;
        private System.Windows.Forms.Timer timerTradesPopup;
        private System.Windows.Forms.ToolStripComboBox trayAccountList;
        private System.Windows.Forms.ToolStripMenuItem menuImportAccount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtAccSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripMenuItem menuDeactivateAuthenticator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label labelVersion;
    }
}

