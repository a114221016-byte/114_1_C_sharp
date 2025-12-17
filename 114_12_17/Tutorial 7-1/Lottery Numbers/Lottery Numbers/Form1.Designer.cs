namespace Lottery_Numbers
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的資源
        /// </summary>
        /// <param name="disposing">如果應受管理的資源應被処棄，則為 true；否則為 false</param>
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
        /// 設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 此方法的內容
        /// </summary>
        private void InitializeComponent()
        {
            // 宣告五個標籤控制項，用來顯示彩票號碼
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.thirdLabel = new System.Windows.Forms.Label();
            this.fourthLabel = new System.Windows.Forms.Label();
            this.fifthLabel = new System.Windows.Forms.Label();
            
            // 宣告兩個按鈕控制項：生成號碼按鈕和離開按鈕
            this.generateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstLabel - 第一個彩票號碼標籤
            // 位置：最左邊，顯示第一個彩票號碼
            this.firstLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLabel.Location = new System.Drawing.Point(14, 9);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(60, 50);
            this.firstLabel.TabIndex = 0;
            this.firstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondLabel - 第二個彩票號碼標籤
            // 位置：由左至右第二個
            this.secondLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabel.Location = new System.Drawing.Point(80, 9);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(60, 50);
            this.secondLabel.TabIndex = 1;
            this.secondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirdLabel - 第三個彩票號碼標籤
            // 位置：由左至右第三個
            this.thirdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdLabel.Location = new System.Drawing.Point(146, 9);
            this.thirdLabel.Name = "thirdLabel";
            this.thirdLabel.Size = new System.Drawing.Size(60, 50);
            this.thirdLabel.TabIndex = 2;
            this.thirdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fourthLabel - 第四個彩票號碼標籤
            // 位置：由左至右第四個
            this.fourthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fourthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthLabel.Location = new System.Drawing.Point(212, 9);
            this.fourthLabel.Name = "fourthLabel";
            this.fourthLabel.Size = new System.Drawing.Size(60, 50);
            this.fourthLabel.TabIndex = 3;
            this.fourthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fifthLabel - 第五個彩票號碼標籤
            // 位置：最右邊，顯示第五個彩票號碼
            this.fifthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fifthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifthLabel.Location = new System.Drawing.Point(278, 9);
            this.fifthLabel.Name = "fifthLabel";
            this.fifthLabel.Size = new System.Drawing.Size(60, 50);
            this.fifthLabel.TabIndex = 4;
            this.fifthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateButton - 生成號碼按鈕
            // 功能：點擊此按鈕會生成並顯示五個彩票號碼
            this.generateButton.Location = new System.Drawing.Point(74, 75);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(100, 40);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "生成號碼";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // exitButton - 離開按鈕
            // 功能：點擊此按鈕會關閉應用程式
            this.exitButton.Location = new System.Drawing.Point(180, 75);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 40);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1 - 主表單
            // 彩票號碼生成應用程式的主視窗
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 130);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.fifthLabel);
            this.Controls.Add(this.fourthLabel);
            this.Controls.Add(this.thirdLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstLabel);
            this.Name = "Form1";
            this.Text = "彩票號碼生成器";
            this.ResumeLayout(false);

        }

        #endregion

        // 五個標籤控制項：用於顯示彩票號碼
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label thirdLabel;
        private System.Windows.Forms.Label fourthLabel;
        private System.Windows.Forms.Label fifthLabel;
        
        // 兩個按鈕控制項：用於生成號碼和離開應用程式
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

