namespace LOginDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;

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
            labelAccount = new Label();
            labelPassword = new Label();
            txtAccount = new TextBox();
            txtPassword = new TextBox();
            btnCheck = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // labelAccount
            // 
            labelAccount.AutoSize = true;
            labelAccount.Font = new Font("Segoe UI", 22F);
            labelAccount.Location = new Point(30, 30);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new Size(163, 60);
            labelAccount.TabIndex = 0;
            labelAccount.Text = "帳號：";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 22F);
            labelPassword.Location = new Point(30, 116);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(163, 60);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "密碼：";
            // 
            // txtAccount
            // 
            txtAccount.Font = new Font("Segoe UI", 22F);
            txtAccount.Location = new Point(187, 30);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(479, 66);
            txtAccount.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 22F);
            txtPassword.Location = new Point(187, 116);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(479, 66);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 22F);
            btnCheck.Location = new Point(302, 210);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(140, 67);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "檢查";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Font = new Font("Segoe UI", 22F);
            lblResult.Location = new Point(133, 298);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(494, 109);
            lblResult.TabIndex = 5;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCheck);
            Controls.Add(txtPassword);
            Controls.Add(labelPassword);
            Controls.Add(txtAccount);
            Controls.Add(labelAccount);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
