namespace Image_Encryption
{
    partial class frmEncryption
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
            this.label1 = new System.Windows.Forms.Label();
            this.ofdSelectImage = new System.Windows.Forms.OpenFileDialog();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.llClear = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(249, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Image Encryption";
            // 
            // ofdSelectImage
            // 
            this.ofdSelectImage.FileName = "ofdSelectImage";
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(468, 181);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(189, 29);
            this.txtKey.TabIndex = 7;
            this.txtKey.Validating += new System.ComponentModel.CancelEventHandler(this.txtKey_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kufi Extended Outline", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(464, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Encryption Key";
            // 
            // llClear
            // 
            this.llClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llClear.Image = global::Image_Encryption.Properties.Resources.rubber;
            this.llClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llClear.LinkColor = System.Drawing.Color.White;
            this.llClear.Location = new System.Drawing.Point(180, 405);
            this.llClear.Name = "llClear";
            this.llClear.Size = new System.Drawing.Size(83, 26);
            this.llClear.TabIndex = 6;
            this.llClear.TabStop = true;
            this.llClear.Text = "Clear";
            this.llClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClear_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Image_Encryption.Properties.Resources.close;
            this.pictureBox3.Location = new System.Drawing.Point(720, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Image_Encryption.Properties.Resources.cyber_security;
            this.pictureBox2.Location = new System.Drawing.Point(587, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Image = global::Image_Encryption.Properties.Resources.data_protection;
            this.btnDecrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecrypt.Location = new System.Drawing.Point(495, 231);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(128, 41);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Image_Encryption.Properties.Resources.encrypted;
            this.pictureBox1.Location = new System.Drawing.Point(168, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImage.ForeColor = System.Drawing.Color.Black;
            this.btnSelectImage.Image = global::Image_Encryption.Properties.Resources.photo__1_;
            this.btnSelectImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectImage.Location = new System.Drawing.Point(148, 355);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(164, 41);
            this.btnSelectImage.TabIndex = 3;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Image = global::Image_Encryption.Properties.Resources.data_encryption;
            this.btnEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncrypt.Location = new System.Drawing.Point(495, 292);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(128, 41);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(109, 108);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(247, 225);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // frmEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(770, 467);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llClear);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.pbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEncryption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEncryption_Load);
            this.Shown += new System.EventHandler(this.frmEncryption_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmEncryption_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.OpenFileDialog ofdSelectImage;
        private System.Windows.Forms.LinkLabel llClear;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

