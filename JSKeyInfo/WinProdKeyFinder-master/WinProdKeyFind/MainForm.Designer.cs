namespace WinProdKeyFind
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbx_Info = new System.Windows.Forms.PictureBox();
            this.ddl_Language = new System.Windows.Forms.ComboBox();
            this.btn_InfosAuslesen = new System.Windows.Forms.Button();
            this.pbx_CopyAll = new System.Windows.Forms.PictureBox();
            this.pbx_OS = new System.Windows.Forms.PictureBox();
            this.pbx_WinKey = new System.Windows.Forms.PictureBox();
            this.txb_OS = new System.Windows.Forms.TextBox();
            this.lbl_WinKey = new System.Windows.Forms.Label();
            this.lbl_OfficeKey = new System.Windows.Forms.Label();
            this.txb_WinKey = new System.Windows.Forms.TextBox();
            this.ttp_ToolTips = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CopyAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_OS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_WinKey)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_Info
            // 
            this.pbx_Info.BackColor = System.Drawing.Color.Transparent;
            this.pbx_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_Info.Image = global::JSKeyInfo.Properties.Resources.info;
            this.pbx_Info.Location = new System.Drawing.Point(142, 103);
            this.pbx_Info.Name = "pbx_Info";
            this.pbx_Info.Size = new System.Drawing.Size(21, 21);
            this.pbx_Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Info.TabIndex = 62;
            this.pbx_Info.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_Info, "Info!");
            this.pbx_Info.Click += new System.EventHandler(this.pbx_Info_Click);
            // 
            // ddl_Language
            // 
            this.ddl_Language.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddl_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Language.FormattingEnabled = true;
            this.ddl_Language.Items.AddRange(new object[] {
            "Deutsch",
            "English"});
            this.ddl_Language.Location = new System.Drawing.Point(12, 103);
            this.ddl_Language.Name = "ddl_Language";
            this.ddl_Language.Size = new System.Drawing.Size(121, 21);
            this.ddl_Language.TabIndex = 61;
            this.ttp_ToolTips.SetToolTip(this.ddl_Language, "Select Language!");
            this.ddl_Language.SelectedIndexChanged += new System.EventHandler(this.ddl_Language_Changed);
            // 
            // btn_InfosAuslesen
            // 
            this.btn_InfosAuslesen.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_InfosAuslesen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InfosAuslesen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InfosAuslesen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InfosAuslesen.Location = new System.Drawing.Point(397, 105);
            this.btn_InfosAuslesen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_InfosAuslesen.Name = "btn_InfosAuslesen";
            this.btn_InfosAuslesen.Size = new System.Drawing.Size(75, 23);
            this.btn_InfosAuslesen.TabIndex = 60;
            this.btn_InfosAuslesen.Text = "erneuern...";
            this.ttp_ToolTips.SetToolTip(this.btn_InfosAuslesen, "Refresh!");
            this.btn_InfosAuslesen.UseVisualStyleBackColor = false;
            this.btn_InfosAuslesen.Click += new System.EventHandler(this.btn_InfosAuslesen_Click);
            // 
            // pbx_CopyAll
            // 
            this.pbx_CopyAll.BackColor = System.Drawing.Color.Transparent;
            this.pbx_CopyAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbx_CopyAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_CopyAll.Image = global::JSKeyInfo.Properties.Resources.copy;
            this.pbx_CopyAll.Location = new System.Drawing.Point(427, 11);
            this.pbx_CopyAll.Name = "pbx_CopyAll";
            this.pbx_CopyAll.Size = new System.Drawing.Size(45, 43);
            this.pbx_CopyAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_CopyAll.TabIndex = 69;
            this.pbx_CopyAll.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_CopyAll, "Copy all!");
            this.pbx_CopyAll.Click += new System.EventHandler(this.pbx_CopyAll_Click);
            // 
            // pbx_OS
            // 
            this.pbx_OS.BackColor = System.Drawing.Color.Transparent;
            this.pbx_OS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbx_OS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_OS.Image = global::JSKeyInfo.Properties.Resources.copy;
            this.pbx_OS.Location = new System.Drawing.Point(392, 36);
            this.pbx_OS.Name = "pbx_OS";
            this.pbx_OS.Size = new System.Drawing.Size(20, 20);
            this.pbx_OS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_OS.TabIndex = 68;
            this.pbx_OS.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_OS, "Copy OS!");
            this.pbx_OS.Click += new System.EventHandler(this.pbx_OfficeKey_Click);
            // 
            // pbx_WinKey
            // 
            this.pbx_WinKey.BackColor = System.Drawing.Color.Transparent;
            this.pbx_WinKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbx_WinKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx_WinKey.Image = global::JSKeyInfo.Properties.Resources.copy;
            this.pbx_WinKey.Location = new System.Drawing.Point(392, 11);
            this.pbx_WinKey.Name = "pbx_WinKey";
            this.pbx_WinKey.Size = new System.Drawing.Size(20, 20);
            this.pbx_WinKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_WinKey.TabIndex = 67;
            this.pbx_WinKey.TabStop = false;
            this.ttp_ToolTips.SetToolTip(this.pbx_WinKey, "Copy Windows Key!");
            this.pbx_WinKey.Click += new System.EventHandler(this.pbx_WinKey_Click);
            // 
            // txb_OS
            // 
            this.txb_OS.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_OS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_OS.Location = new System.Drawing.Point(142, 36);
            this.txb_OS.Margin = new System.Windows.Forms.Padding(2);
            this.txb_OS.Name = "txb_OS";
            this.txb_OS.Size = new System.Drawing.Size(245, 20);
            this.txb_OS.TabIndex = 66;
            // 
            // lbl_WinKey
            // 
            this.lbl_WinKey.AutoSize = true;
            this.lbl_WinKey.BackColor = System.Drawing.Color.Transparent;
            this.lbl_WinKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WinKey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_WinKey.Location = new System.Drawing.Point(9, 14);
            this.lbl_WinKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_WinKey.Name = "lbl_WinKey";
            this.lbl_WinKey.Size = new System.Drawing.Size(87, 13);
            this.lbl_WinKey.TabIndex = 65;
            this.lbl_WinKey.Text = "Windows Key:";
            // 
            // lbl_OfficeKey
            // 
            this.lbl_OfficeKey.AutoSize = true;
            this.lbl_OfficeKey.BackColor = System.Drawing.Color.Transparent;
            this.lbl_OfficeKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OfficeKey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_OfficeKey.Location = new System.Drawing.Point(10, 40);
            this.lbl_OfficeKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_OfficeKey.Name = "lbl_OfficeKey";
            this.lbl_OfficeKey.Size = new System.Drawing.Size(95, 13);
            this.lbl_OfficeKey.TabIndex = 64;
            this.lbl_OfficeKey.Text = "Betriebssystem:";
            // 
            // txb_WinKey
            // 
            this.txb_WinKey.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txb_WinKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_WinKey.Location = new System.Drawing.Point(142, 11);
            this.txb_WinKey.Margin = new System.Windows.Forms.Padding(2);
            this.txb_WinKey.Name = "txb_WinKey";
            this.txb_WinKey.Size = new System.Drawing.Size(245, 20);
            this.txb_WinKey.TabIndex = 63;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JSKeyInfo.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 136);
            this.Controls.Add(this.pbx_CopyAll);
            this.Controls.Add(this.pbx_OS);
            this.Controls.Add(this.pbx_WinKey);
            this.Controls.Add(this.txb_OS);
            this.Controls.Add(this.lbl_WinKey);
            this.Controls.Add(this.lbl_OfficeKey);
            this.Controls.Add(this.txb_WinKey);
            this.Controls.Add(this.pbx_Info);
            this.Controls.Add(this.ddl_Language);
            this.Controls.Add(this.btn_InfosAuslesen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JSKeyInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_CopyAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_OS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_WinKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Info;
        private System.Windows.Forms.ComboBox ddl_Language;
        private System.Windows.Forms.Button btn_InfosAuslesen;
        private System.Windows.Forms.PictureBox pbx_CopyAll;
        private System.Windows.Forms.PictureBox pbx_OS;
        private System.Windows.Forms.PictureBox pbx_WinKey;
        private System.Windows.Forms.TextBox txb_OS;
        private System.Windows.Forms.Label lbl_WinKey;
        private System.Windows.Forms.Label lbl_OfficeKey;
        private System.Windows.Forms.TextBox txb_WinKey;
        private System.Windows.Forms.ToolTip ttp_ToolTips;
    }
}

