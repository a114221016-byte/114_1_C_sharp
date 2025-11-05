namespace RadioButtonDemo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.juiceButton2 = new System.Windows.Forms.RadioButton();
            this.blackteaButton2 = new System.Windows.Forms.RadioButton();
            this.milkteaButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.peasanradioButton4 = new System.Windows.Forms.RadioButton();
            this.hamsanradioButton3 = new System.Windows.Forms.RadioButton();
            this.tunaSanButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.juiceButton2);
            this.groupBox1.Controls.Add(this.blackteaButton2);
            this.groupBox1.Controls.Add(this.milkteaButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(40, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 555);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "飲料";
            // 
            // juiceButton2
            // 
            this.juiceButton2.AutoSize = true;
            this.juiceButton2.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.juiceButton2.Location = new System.Drawing.Point(116, 438);
            this.juiceButton2.Name = "juiceButton2";
            this.juiceButton2.Size = new System.Drawing.Size(122, 44);
            this.juiceButton2.TabIndex = 7;
            this.juiceButton2.TabStop = true;
            this.juiceButton2.Text = "果汁";
            this.juiceButton2.UseVisualStyleBackColor = true;
            // 
            // blackteaButton2
            // 
            this.blackteaButton2.AutoSize = true;
            this.blackteaButton2.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.blackteaButton2.Location = new System.Drawing.Point(116, 316);
            this.blackteaButton2.Name = "blackteaButton2";
            this.blackteaButton2.Size = new System.Drawing.Size(122, 44);
            this.blackteaButton2.TabIndex = 6;
            this.blackteaButton2.TabStop = true;
            this.blackteaButton2.Text = "紅茶";
            this.blackteaButton2.UseVisualStyleBackColor = true;
            // 
            // milkteaButton2
            // 
            this.milkteaButton2.AutoSize = true;
            this.milkteaButton2.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.milkteaButton2.Location = new System.Drawing.Point(116, 191);
            this.milkteaButton2.Name = "milkteaButton2";
            this.milkteaButton2.Size = new System.Drawing.Size(122, 44);
            this.milkteaButton2.TabIndex = 5;
            this.milkteaButton2.TabStop = true;
            this.milkteaButton2.Text = "奶茶";
            this.milkteaButton2.UseVisualStyleBackColor = true;
            this.milkteaButton2.CheckedChanged += new System.EventHandler(this.milkteaButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton1.Location = new System.Drawing.Point(116, 82);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 44);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "咖啡";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.peasanradioButton4);
            this.groupBox2.Controls.Add(this.hamsanradioButton3);
            this.groupBox2.Controls.Add(this.tunaSanButton2);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(490, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 463);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "三明治";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // peasanradioButton4
            // 
            this.peasanradioButton4.AutoSize = true;
            this.peasanradioButton4.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.peasanradioButton4.Location = new System.Drawing.Point(54, 335);
            this.peasanradioButton4.Name = "peasanradioButton4";
            this.peasanradioButton4.Size = new System.Drawing.Size(242, 44);
            this.peasanradioButton4.TabIndex = 9;
            this.peasanradioButton4.TabStop = true;
            this.peasanradioButton4.Text = "果醬三明治";
            this.peasanradioButton4.UseVisualStyleBackColor = true;
            // 
            // hamsanradioButton3
            // 
            this.hamsanradioButton3.AutoSize = true;
            this.hamsanradioButton3.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hamsanradioButton3.Location = new System.Drawing.Point(54, 210);
            this.hamsanradioButton3.Name = "hamsanradioButton3";
            this.hamsanradioButton3.Size = new System.Drawing.Size(242, 44);
            this.hamsanradioButton3.TabIndex = 8;
            this.hamsanradioButton3.TabStop = true;
            this.hamsanradioButton3.Text = "火腿三明治";
            this.hamsanradioButton3.UseVisualStyleBackColor = true;
            // 
            // tunaSanButton2
            // 
            this.tunaSanButton2.AutoSize = true;
            this.tunaSanButton2.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tunaSanButton2.Location = new System.Drawing.Point(54, 83);
            this.tunaSanButton2.Name = "tunaSanButton2";
            this.tunaSanButton2.Size = new System.Drawing.Size(242, 44);
            this.tunaSanButton2.TabIndex = 7;
            this.tunaSanButton2.TabStop = true;
            this.tunaSanButton2.Text = "鮪魚三明治";
            this.tunaSanButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 644);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton juiceButton2;
        private System.Windows.Forms.RadioButton blackteaButton2;
        private System.Windows.Forms.RadioButton milkteaButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton peasanradioButton4;
        private System.Windows.Forms.RadioButton hamsanradioButton3;
        private System.Windows.Forms.RadioButton tunaSanButton2;
    }
}

