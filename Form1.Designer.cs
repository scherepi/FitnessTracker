namespace FitnessTracker
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.signInBtn = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(924, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to your Fitness Tracker!";
            // 
            // signInBtn
            // 
            this.signInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.Location = new System.Drawing.Point(597, 288);
            this.signInBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(342, 149);
            this.signInBtn.TabIndex = 1;
            this.signInBtn.Text = "SIGN IN";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(384, 525);
            this.createButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(783, 149);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "CREATE ACCOUNT";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1560, 929);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Button createButton;
    }
}

