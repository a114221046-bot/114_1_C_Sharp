namespace Q1
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
            this.scissorButton = new System.Windows.Forms.Button();
            this.StoneButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.playerLabel = new System.Windows.Forms.Label();
            this.computerLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.ComputerpictureBox = new System.Windows.Forms.PictureBox();
            this.PlayerpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scissorButton
            // 
            this.scissorButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.scissorButton.Location = new System.Drawing.Point(792, 542);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(173, 92);
            this.scissorButton.TabIndex = 3;
            this.scissorButton.Text = "剪刀";
            this.scissorButton.UseVisualStyleBackColor = true;
            // 
            // StoneButton
            // 
            this.StoneButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.StoneButton.Location = new System.Drawing.Point(157, 542);
            this.StoneButton.Name = "StoneButton";
            this.StoneButton.Size = new System.Drawing.Size(173, 92);
            this.StoneButton.TabIndex = 4;
            this.StoneButton.Text = "石頭";
            this.StoneButton.UseVisualStyleBackColor = true;
            // 
            // paperButton
            // 
            this.paperButton.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.paperButton.Location = new System.Drawing.Point(486, 542);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(173, 92);
            this.paperButton.TabIndex = 5;
            this.paperButton.Text = "布";
            this.paperButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 16F);
            this.exitButton.Location = new System.Drawing.Point(458, 698);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(239, 92);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "結束遊戲";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("新細明體", 25F);
            this.playerLabel.Location = new System.Drawing.Point(724, 56);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(172, 50);
            this.playerLabel.TabIndex = 7;
            this.playerLabel.Text = "玩家出";
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.Font = new System.Drawing.Font("新細明體", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.computerLabel.Location = new System.Drawing.Point(231, 56);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(172, 50);
            this.computerLabel.TabIndex = 8;
            this.computerLabel.Text = "電腦出";
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Font = new System.Drawing.Font("新細明體", 16F);
            this.resultLabel.Location = new System.Drawing.Point(357, 417);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(422, 77);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // ComputerpictureBox
            // 
            this.ComputerpictureBox.Location = new System.Drawing.Point(137, 169);
            this.ComputerpictureBox.Name = "ComputerpictureBox";
            this.ComputerpictureBox.Size = new System.Drawing.Size(345, 191);
            this.ComputerpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ComputerpictureBox.TabIndex = 2;
            this.ComputerpictureBox.TabStop = false;
            this.ComputerpictureBox.Click += new System.EventHandler(this.ComputerpictureBox_Click);
            // 
            // PlayerpictureBox
            // 
            this.PlayerpictureBox.Location = new System.Drawing.Point(638, 171);
            this.PlayerpictureBox.Name = "PlayerpictureBox";
            this.PlayerpictureBox.Size = new System.Drawing.Size(345, 189);
            this.PlayerpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerpictureBox.TabIndex = 1;
            this.PlayerpictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 824);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.StoneButton);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.ComputerpictureBox);
            this.Controls.Add(this.PlayerpictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ComputerpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PlayerpictureBox;
        private System.Windows.Forms.PictureBox ComputerpictureBox;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Button StoneButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

