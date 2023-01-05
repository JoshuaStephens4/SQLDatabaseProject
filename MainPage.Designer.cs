namespace SQLDatabaseProject
{
    partial class MainPage
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
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.cmdCountryMain = new System.Windows.Forms.ComboBox();
            this.txtPasswordMain = new System.Windows.Forms.TextBox();
            this.txtEmailMain = new System.Windows.Forms.TextBox();
            this.txtNameMain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.lblWelcomeName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.Location = new System.Drawing.Point(191, 412);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(347, 64);
            this.btnUpdateInfo.TabIndex = 18;
            this.btnUpdateInfo.Text = "Update Account";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // cmdCountryMain
            // 
            this.cmdCountryMain.FormattingEnabled = true;
            this.cmdCountryMain.Items.AddRange(new object[] {
            "United States of America",
            "England",
            "Canada",
            "Mexico"});
            this.cmdCountryMain.Location = new System.Drawing.Point(191, 353);
            this.cmdCountryMain.Name = "cmdCountryMain";
            this.cmdCountryMain.Size = new System.Drawing.Size(347, 28);
            this.cmdCountryMain.TabIndex = 17;
            // 
            // txtPasswordMain
            // 
            this.txtPasswordMain.Location = new System.Drawing.Point(191, 298);
            this.txtPasswordMain.Name = "txtPasswordMain";
            this.txtPasswordMain.Size = new System.Drawing.Size(347, 26);
            this.txtPasswordMain.TabIndex = 16;
            // 
            // txtEmailMain
            // 
            this.txtEmailMain.Location = new System.Drawing.Point(191, 246);
            this.txtEmailMain.Name = "txtEmailMain";
            this.txtEmailMain.Size = new System.Drawing.Size(347, 26);
            this.txtEmailMain.TabIndex = 15;
            // 
            // txtNameMain
            // 
            this.txtNameMain.Location = new System.Drawing.Point(191, 193);
            this.txtNameMain.Name = "txtNameMain";
            this.txtNameMain.Size = new System.Drawing.Size(347, 26);
            this.txtNameMain.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "Country:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(83, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 54);
            this.label1.TabIndex = 19;
            this.label1.Text = "Change Account Settings";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(601, 246);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(347, 64);
            this.btnDeleteAccount.TabIndex = 20;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // lblWelcomeName
            // 
            this.lblWelcomeName.AutoSize = true;
            this.lblWelcomeName.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWelcomeName.Location = new System.Drawing.Point(309, 9);
            this.lblWelcomeName.Name = "lblWelcomeName";
            this.lblWelcomeName.Size = new System.Drawing.Size(388, 54);
            this.lblWelcomeName.TabIndex = 21;
            this.lblWelcomeName.Text = "Welcome username";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 545);
            this.Controls.Add(this.lblWelcomeName);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.cmdCountryMain);
            this.Controls.Add(this.txtPasswordMain);
            this.Controls.Add(this.txtEmailMain);
            this.Controls.Add(this.txtNameMain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.ComboBox cmdCountryMain;
        private System.Windows.Forms.TextBox txtPasswordMain;
        private System.Windows.Forms.TextBox txtEmailMain;
        private System.Windows.Forms.TextBox txtNameMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Label lblWelcomeName;
    }
}