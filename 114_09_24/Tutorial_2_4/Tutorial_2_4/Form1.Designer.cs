namespace Tutorial_2_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.germanPicture = new System.Windows.Forms.PictureBox();
            this.francePicture = new System.Windows.Forms.PictureBox();
            this.finlandPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.germanPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(228, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "點選國旗會出現國家名稱";
            // 
            // countryLabel
            // 
            this.countryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countryLabel.BackColor = System.Drawing.SystemColors.Control;
            this.countryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countryLabel.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countryLabel.Location = new System.Drawing.Point(207, 338);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(387, 70);
            this.countryLabel.TabIndex = 1;
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // germanPicture
            // 
            this.germanPicture.Image = global::Tutorial_2_4.Properties.Resources.Germany;
            this.germanPicture.Location = new System.Drawing.Point(556, 164);
            this.germanPicture.Name = "germanPicture";
            this.germanPicture.Size = new System.Drawing.Size(200, 130);
            this.germanPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.germanPicture.TabIndex = 4;
            this.germanPicture.TabStop = false;
            this.germanPicture.Click += new System.EventHandler(this.germanPicture_Click);
            // 
            // francePicture
            // 
            this.francePicture.Image = global::Tutorial_2_4.Properties.Resources.France;
            this.francePicture.Location = new System.Drawing.Point(298, 164);
            this.francePicture.Name = "francePicture";
            this.francePicture.Size = new System.Drawing.Size(200, 130);
            this.francePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.francePicture.TabIndex = 3;
            this.francePicture.TabStop = false;
            this.francePicture.Click += new System.EventHandler(this.francePicture_Click);
            // 
            // finlandPicture
            // 
            this.finlandPicture.Image = global::Tutorial_2_4.Properties.Resources.Finland;
            this.finlandPicture.Location = new System.Drawing.Point(32, 164);
            this.finlandPicture.Name = "finlandPicture";
            this.finlandPicture.Size = new System.Drawing.Size(200, 130);
            this.finlandPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finlandPicture.TabIndex = 2;
            this.finlandPicture.TabStop = false;
            this.finlandPicture.Click += new System.EventHandler(this.finlandPicture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.germanPicture);
            this.Controls.Add(this.francePicture);
            this.Controls.Add(this.finlandPicture);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.germanPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.PictureBox finlandPicture;
        private System.Windows.Forms.PictureBox francePicture;
        private System.Windows.Forms.PictureBox germanPicture;
    }
}

