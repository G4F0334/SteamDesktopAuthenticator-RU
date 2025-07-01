namespace Steam_Desktop_Authenticator
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            chkPeriodicChecking = new System.Windows.Forms.CheckBox();
            btnSave = new System.Windows.Forms.Button();
            numPeriodicInterval = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            chkCheckAll = new System.Windows.Forms.CheckBox();
            chkConfirmMarket = new System.Windows.Forms.CheckBox();
            chkConfirmTrades = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)numPeriodicInterval).BeginInit();
            SuspendLayout();
            // 
            // chkPeriodicChecking
            // 
            chkPeriodicChecking.AutoSize = true;
            chkPeriodicChecking.Location = new System.Drawing.Point(12, 12);
            chkPeriodicChecking.Name = "chkPeriodicChecking";
            chkPeriodicChecking.Size = new System.Drawing.Size(306, 30);
            chkPeriodicChecking.TabIndex = 0;
            chkPeriodicChecking.Text = "Периодически проверять новые подтверждения\r\nи показывать всплывающее окно при их появлении";
            chkPeriodicChecking.UseVisualStyleBackColor = true;
            chkPeriodicChecking.CheckedChanged += chkPeriodicChecking_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.Location = new System.Drawing.Point(12, 152);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(299, 38);
            btnSave.TabIndex = 1;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // numPeriodicInterval
            // 
            numPeriodicInterval.Location = new System.Drawing.Point(12, 51);
            numPeriodicInterval.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numPeriodicInterval.Name = "numPeriodicInterval";
            numPeriodicInterval.Size = new System.Drawing.Size(41, 22);
            numPeriodicInterval.TabIndex = 2;
            numPeriodicInterval.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(59, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(151, 26);
            label1.TabIndex = 3;
            label1.Text = "Секунд между проверками\nподтверждений";
            // 
            // chkCheckAll
            // 
            chkCheckAll.AutoSize = true;
            chkCheckAll.Location = new System.Drawing.Point(12, 81);
            chkCheckAll.Name = "chkCheckAll";
            chkCheckAll.Size = new System.Drawing.Size(260, 17);
            chkCheckAll.TabIndex = 4;
            chkCheckAll.Text = "Проверять все аккаунты на подтверждения";
            chkCheckAll.UseVisualStyleBackColor = true;
            // 
            // chkConfirmMarket
            // 
            chkConfirmMarket.AutoSize = true;
            chkConfirmMarket.Location = new System.Drawing.Point(12, 104);
            chkConfirmMarket.Name = "chkConfirmMarket";
            chkConfirmMarket.Size = new System.Drawing.Size(279, 17);
            chkConfirmMarket.TabIndex = 5;
            chkConfirmMarket.Text = "Автоматически подтверждать сделки на рынке";
            chkConfirmMarket.UseVisualStyleBackColor = true;
            chkConfirmMarket.CheckedChanged += chkConfirmMarket_CheckedChanged;
            // 
            // chkConfirmTrades
            // 
            chkConfirmTrades.AutoSize = true;
            chkConfirmTrades.Location = new System.Drawing.Point(12, 127);
            chkConfirmTrades.Name = "chkConfirmTrades";
            chkConfirmTrades.Size = new System.Drawing.Size(233, 17);
            chkConfirmTrades.TabIndex = 6;
            chkConfirmTrades.Text = "Автоматически подтверждать обмены";
            chkConfirmTrades.UseVisualStyleBackColor = true;
            chkConfirmTrades.CheckedChanged += chkConfirmTrades_CheckedChanged;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(319, 202);
            Controls.Add(chkConfirmTrades);
            Controls.Add(chkConfirmMarket);
            Controls.Add(chkCheckAll);
            Controls.Add(label1);
            Controls.Add(numPeriodicInterval);
            Controls.Add(btnSave);
            Controls.Add(chkPeriodicChecking);
            Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SettingsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)numPeriodicInterval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox chkPeriodicChecking;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numPeriodicInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCheckAll;
        private System.Windows.Forms.CheckBox chkConfirmMarket;
        private System.Windows.Forms.CheckBox chkConfirmTrades;
    }
}