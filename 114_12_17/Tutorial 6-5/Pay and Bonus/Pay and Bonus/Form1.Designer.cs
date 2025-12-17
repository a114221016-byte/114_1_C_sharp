namespace Pay_and_Bonus
{
    partial class Form1
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
            this.grossPayPromptLabel = new System.Windows.Forms.Label();
            this.bonusPromptLabel = new System.Windows.Forms.Label();
            this.grossPayTextBox = new System.Windows.Forms.TextBox();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.contributionLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grossPayPromptLabel
            // 
            this.grossPayPromptLabel.AutoSize = true;
            this.grossPayPromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.grossPayPromptLabel.Location = new System.Drawing.Point(20, 15);
            this.grossPayPromptLabel.Name = "grossPayPromptLabel";
            this.grossPayPromptLabel.Size = new System.Drawing.Size(160, 31);
            this.grossPayPromptLabel.TabIndex = 0;
            this.grossPayPromptLabel.Text = "總毛額薪資：";
            // 
            // bonusPromptLabel
            // 
            this.bonusPromptLabel.AutoSize = true;
            this.bonusPromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.bonusPromptLabel.Location = new System.Drawing.Point(20, 60);
            this.bonusPromptLabel.Name = "bonusPromptLabel";
            this.bonusPromptLabel.Size = new System.Drawing.Size(160, 31);
            this.bonusPromptLabel.TabIndex = 1;
            this.bonusPromptLabel.Text = "獎金金額：";
            // 
            // grossPayTextBox
            // 
            this.grossPayTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.grossPayTextBox.Location = new System.Drawing.Point(200, 12);
            this.grossPayTextBox.Name = "grossPayTextBox";
            this.grossPayTextBox.Size = new System.Drawing.Size(150, 39);
            this.grossPayTextBox.TabIndex = 2;
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.bonusTextBox.Location = new System.Drawing.Point(200, 57);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(150, 39);
            this.bonusTextBox.TabIndex = 3;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(20, 110);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(160, 31);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "退休金提撥：";
            // 
            // contributionLabel
            // 
            this.contributionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contributionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.contributionLabel.Location = new System.Drawing.Point(200, 107);
            this.contributionLabel.Name = "contributionLabel";
            this.contributionLabel.Size = new System.Drawing.Size(150, 40);
            this.contributionLabel.TabIndex = 5;
            this.contributionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.calculateButton.Location = new System.Drawing.Point(20, 160);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(150, 50);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "計算";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.exitButton.Location = new System.Drawing.Point(200, 160);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 50);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 225);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.contributionLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.grossPayTextBox);
            this.Controls.Add(this.bonusPromptLabel);
            this.Controls.Add(this.grossPayPromptLabel);
            this.Name = "Form1";
            this.Text = "薪資和獎金計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label grossPayPromptLabel;
        private System.Windows.Forms.Label bonusPromptLabel;
        private System.Windows.Forms.TextBox grossPayTextBox;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label contributionLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

