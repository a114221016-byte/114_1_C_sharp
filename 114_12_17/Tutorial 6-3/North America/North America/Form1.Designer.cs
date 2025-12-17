namespace North_America
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
        /// 此方法由設計工具產生。不要用程式碼編輯器修改方法內部結構，
        /// 若需變更元件屬性請在設計檢視 (Form Designer) 中操作或小心手動維護。
        /// 以下 InitializeComponent 已以繁體中文加入詳細註解，並將所有顯示文字改為繁體中文，
        /// 同時將各元件字型改為 18pt 並適度調整大小與位置以配合較大字型顯示。
        /// </summary>
        private void InitializeComponent()
        {
            // 宣告與初始化元件
            this.exitButton = new System.Windows.Forms.Button();
            this.getCountriesButton = new System.Windows.Forms.Button();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            // 此按鈕用於關閉表單（結束應用程式視窗）。
            // 設定字型為 18pt，以便顯示繁體中文文字時更清晰可讀。
            // 調整大小與位置，使按鈕在視窗下方置中並有足夠的點擊範圍。
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(220, 280);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 50);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // getCountriesButton
            // 
            // 此按鈕用於讀取或載入國家清單（來源由程式另行處理）。
            // 同樣使用 18pt 字型，並與結束按鈕放置於視窗下方，使介面直覺。
            this.getCountriesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getCountriesButton.Location = new System.Drawing.Point(80, 280);
            this.getCountriesButton.Name = "getCountriesButton";
            this.getCountriesButton.Size = new System.Drawing.Size(120, 50);
            this.getCountriesButton.TabIndex = 6;
            this.getCountriesButton.Text = "取得國家";
            this.getCountriesButton.UseVisualStyleBackColor = true;
            this.getCountriesButton.Click += new System.EventHandler(this.getCountriesButton_Click);
            // 
            // outputDescriptionLabel
            // 
            // 此標籤用於說明清單的內容：顯示為「北美洲的國家」或類似描述。
            // 將 AutoSize 設為 false 並明確指定大小，以便在使用大字型時版面穩定不會自動換行。
            this.outputDescriptionLabel.AutoSize = false;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(15, 12);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(390, 36);
            this.outputDescriptionLabel.TabIndex = 5;
            this.outputDescriptionLabel.Text = "北美洲的國家列表";
            // 
            // countriesListBox
            // 
            // 此清單框顯示國家名稱。已將字型改為 18pt 並加大尺寸以容納較長的名稱與更大字體。
            // Enabled/FormattingEnabled 等屬性保留原狀以維持清單行為一致性。
            this.countriesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.ItemHeight = 29;
            this.countriesListBox.Location = new System.Drawing.Point(15, 60);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(390, 200);
            this.countriesListBox.TabIndex = 4;
            // 
            // Form1
            // 
            // 表單整體調整：擴大 ClientSize 以容納 18pt 字型的標籤、清單與按鈕。
            // 表單標題改為繁體中文「北美洲」。
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 360);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getCountriesButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.countriesListBox);
            this.Name = "Form1";
            this.Text = "北美洲";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button getCountriesButton;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.ListBox countriesListBox;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

