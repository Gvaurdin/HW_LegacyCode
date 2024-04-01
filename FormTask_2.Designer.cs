namespace HW_LegacyCode
{
    partial class FormTask_2
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAPIControl = new System.Windows.Forms.Button();
            this.buttonThread = new System.Windows.Forms.Button();
            this.radioButtonChangeTitleWindow = new System.Windows.Forms.RadioButton();
            this.radioButtonCloseWindow = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonAPIControl
            // 
            this.buttonAPIControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonAPIControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAPIControl.Location = new System.Drawing.Point(12, 275);
            this.buttonAPIControl.Name = "buttonAPIControl";
            this.buttonAPIControl.Size = new System.Drawing.Size(206, 75);
            this.buttonAPIControl.TabIndex = 0;
            this.buttonAPIControl.Text = "API control";
            this.buttonAPIControl.UseVisualStyleBackColor = false;
            this.buttonAPIControl.Click += new System.EventHandler(this.buttonAPIControl_Click);
            // 
            // buttonThread
            // 
            this.buttonThread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThread.Location = new System.Drawing.Point(275, 275);
            this.buttonThread.Name = "buttonThread";
            this.buttonThread.Size = new System.Drawing.Size(206, 75);
            this.buttonThread.TabIndex = 1;
            this.buttonThread.Text = "Open thread";
            this.buttonThread.UseVisualStyleBackColor = false;
            this.buttonThread.Click += new System.EventHandler(this.buttonThread_Click);
            // 
            // radioButtonChangeTitleWindow
            // 
            this.radioButtonChangeTitleWindow.AutoSize = true;
            this.radioButtonChangeTitleWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radioButtonChangeTitleWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonChangeTitleWindow.Location = new System.Drawing.Point(21, 215);
            this.radioButtonChangeTitleWindow.Name = "radioButtonChangeTitleWindow";
            this.radioButtonChangeTitleWindow.Size = new System.Drawing.Size(197, 28);
            this.radioButtonChangeTitleWindow.TabIndex = 2;
            this.radioButtonChangeTitleWindow.TabStop = true;
            this.radioButtonChangeTitleWindow.Text = "Change title window";
            this.radioButtonChangeTitleWindow.UseVisualStyleBackColor = false;
            // 
            // radioButtonCloseWindow
            // 
            this.radioButtonCloseWindow.AutoSize = true;
            this.radioButtonCloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioButtonCloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonCloseWindow.Location = new System.Drawing.Point(275, 215);
            this.radioButtonCloseWindow.Name = "radioButtonCloseWindow";
            this.radioButtonCloseWindow.Size = new System.Drawing.Size(146, 28);
            this.radioButtonCloseWindow.TabIndex = 3;
            this.radioButtonCloseWindow.TabStop = true;
            this.radioButtonCloseWindow.Text = "Close window";
            this.radioButtonCloseWindow.UseVisualStyleBackColor = false;
            // 
            // FormTask_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(493, 362);
            this.Controls.Add(this.radioButtonCloseWindow);
            this.Controls.Add(this.radioButtonChangeTitleWindow);
            this.Controls.Add(this.buttonThread);
            this.Controls.Add(this.buttonAPIControl);
            this.Name = "FormTask_2";
            this.Text = "FormInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAPIControl;
        private System.Windows.Forms.Button buttonThread;
        private System.Windows.Forms.RadioButton radioButtonChangeTitleWindow;
        private System.Windows.Forms.RadioButton radioButtonCloseWindow;
    }
}

