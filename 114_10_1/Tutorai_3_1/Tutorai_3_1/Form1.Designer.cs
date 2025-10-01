namespace Tutorai_3_1
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dayofweek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dayofmonth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.dayofyear = new System.Windows.Forms.TextBox();
            this.showdatebutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(91, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "星期:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dayofweek
            // 
            this.dayofweek.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.dayofweek.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayofweek.Location = new System.Drawing.Point(229, 22);
            this.dayofweek.Name = "dayofweek";
            this.dayofweek.Size = new System.Drawing.Size(283, 51);
            this.dayofweek.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(127, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "月:";
            // 
            // dayofmonth
            // 
            this.dayofmonth.AutoSize = true;
            this.dayofmonth.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayofmonth.Location = new System.Drawing.Point(127, 175);
            this.dayofmonth.Name = "dayofmonth";
            this.dayofmonth.Size = new System.Drawing.Size(60, 36);
            this.dayofmonth.TabIndex = 6;
            this.dayofmonth.Text = "日:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(127, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "年:";
            // 
            // month
            // 
            this.month.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.month.Location = new System.Drawing.Point(229, 92);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(283, 51);
            this.month.TabIndex = 8;
            // 
            // day
            // 
            this.day.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.day.Location = new System.Drawing.Point(229, 172);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(283, 51);
            this.day.TabIndex = 9;
            // 
            // dayofyear
            // 
            this.dayofyear.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayofyear.Location = new System.Drawing.Point(230, 249);
            this.dayofyear.Name = "dayofyear";
            this.dayofyear.Size = new System.Drawing.Size(283, 51);
            this.dayofyear.TabIndex = 10;
            // 
            // showdatebutton
            // 
            this.showdatebutton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showdatebutton.Location = new System.Drawing.Point(40, 379);
            this.showdatebutton.Name = "showdatebutton";
            this.showdatebutton.Size = new System.Drawing.Size(175, 50);
            this.showdatebutton.TabIndex = 11;
            this.showdatebutton.Text = "顯示日期";
            this.showdatebutton.UseVisualStyleBackColor = true;
            this.showdatebutton.Click += new System.EventHandler(this.showdatebutton_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Location = new System.Drawing.Point(40, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(668, 40);
            this.label5.TabIndex = 12;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clear.Location = new System.Drawing.Point(282, 379);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(175, 50);
            this.clear.TabIndex = 13;
            this.clear.Text = "清除";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.output.Location = new System.Drawing.Point(533, 379);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(175, 50);
            this.output.TabIndex = 14;
            this.output.Text = "離開";
            this.output.UseVisualStyleBackColor = true;
            this.output.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 455);
            this.Controls.Add(this.output);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showdatebutton);
            this.Controls.Add(this.dayofyear);
            this.Controls.Add(this.day);
            this.Controls.Add(this.month);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dayofmonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dayofweek);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dayofweek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dayofmonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.TextBox dayofyear;
        private System.Windows.Forms.Button showdatebutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button output;
    }
}

