namespace HW_LegacyCode
{
    partial class Form_Task_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Task_4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonShowText = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.roundedButtonShowText = new HW_LegacyCode.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonShowText
            // 
            this.buttonShowText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonShowText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonShowText.FlatAppearance.BorderSize = 0;
            this.buttonShowText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowText.Location = new System.Drawing.Point(22, 273);
            this.buttonShowText.Name = "buttonShowText";
            this.buttonShowText.Size = new System.Drawing.Size(122, 35);
            this.buttonShowText.TabIndex = 1;
            this.buttonShowText.Text = "ShowText";
            this.buttonShowText.UseVisualStyleBackColor = false;
            this.buttonShowText.Click += new System.EventHandler(this.buttonShowText_Click);
            this.buttonShowText.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonShowText_Paint);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(188, 273);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(343, 20);
            this.textBox.TabIndex = 2;
            // 
            // roundedButtonShowText
            // 
            this.roundedButtonShowText.BackColor = System.Drawing.Color.CadetBlue;
            this.roundedButtonShowText.FlatAppearance.BorderSize = 0;
            this.roundedButtonShowText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButtonShowText.Location = new System.Drawing.Point(22, 327);
            this.roundedButtonShowText.Name = "roundedButtonShowText";
            this.roundedButtonShowText.Size = new System.Drawing.Size(122, 36);
            this.roundedButtonShowText.TabIndex = 3;
            this.roundedButtonShowText.Text = "ShowText";
            this.roundedButtonShowText.UseVisualStyleBackColor = false;
            this.roundedButtonShowText.Click += new System.EventHandler(this.roundedButtonShowText_Click);
            // 
            // Form_Task_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(543, 375);
            this.Controls.Add(this.roundedButtonShowText);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonShowText);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Task_4";
            this.Text = "Form_Task_4";
            this.Load += new System.EventHandler(this.Form_Task_4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonShowText;
        private System.Windows.Forms.TextBox textBox;
        private RoundedButton roundedButtonShowText;
    }
}