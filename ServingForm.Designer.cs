﻿namespace BasicQueueCashier
{
    partial class ServingForm
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
            label1 = new Label();
            ServingNumber = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 57);
            label1.Name = "label1";
            label1.Size = new Size(140, 22);
            label1.TabIndex = 0;
            label1.Text = "* NOW SERVING";
            // 
            // ServingNumber
            // 
            ServingNumber.AutoSize = true;
            ServingNumber.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ServingNumber.Location = new Point(114, 108);
            ServingNumber.Name = "ServingNumber";
            ServingNumber.Size = new Size(0, 22);
            ServingNumber.TabIndex = 1;
            ServingNumber.Click += ServingNumber_Click;
            // 
            // ServingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 199);
            Controls.Add(ServingNumber);
            Controls.Add(label1);
            Name = "ServingForm";
            Text = "ServingForm";
            Load += ServingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label ServingNumber;
    }
}