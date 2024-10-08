namespace FitnessTracker
{
    partial class Form2
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
            this.createFrame = new System.Windows.Forms.GroupBox();
            this.incorrectMessage = new System.Windows.Forms.Label();
            this.submit_Btn = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.userField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign in to your account!";
            // 
            // createFrame
            // 
            this.createFrame.Controls.Add(this.incorrectMessage);
            this.createFrame.Controls.Add(this.submit_Btn);
            this.createFrame.Controls.Add(this.passField);
            this.createFrame.Controls.Add(this.userField);
            this.createFrame.Controls.Add(this.label3);
            this.createFrame.Controls.Add(this.label2);
            this.createFrame.Location = new System.Drawing.Point(107, 122);
            this.createFrame.Name = "createFrame";
            this.createFrame.Size = new System.Drawing.Size(452, 207);
            this.createFrame.TabIndex = 7;
            this.createFrame.TabStop = false;
            // 
            // incorrectMessage
            // 
            this.incorrectMessage.AutoSize = true;
            this.incorrectMessage.Location = new System.Drawing.Point(145, 110);
            this.incorrectMessage.Name = "incorrectMessage";
            this.incorrectMessage.Size = new System.Drawing.Size(284, 13);
            this.incorrectMessage.TabIndex = 9;
            this.incorrectMessage.Text = "Sorry, an account with those credentials couldn\'t be found.";
            // 
            // submit_Btn
            // 
            this.submit_Btn.Location = new System.Drawing.Point(149, 130);
            this.submit_Btn.Name = "submit_Btn";
            this.submit_Btn.Size = new System.Drawing.Size(270, 41);
            this.submit_Btn.TabIndex = 5;
            this.submit_Btn.Text = "Start your fitness journey!";
            this.submit_Btn.UseVisualStyleBackColor = true;
            this.submit_Btn.Click += new System.EventHandler(this.submit_Btn_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.Location = new System.Drawing.Point(149, 78);
            this.passField.Name = "passField";
            this.passField.PasswordChar = '*';
            this.passField.Size = new System.Drawing.Size(270, 23);
            this.passField.TabIndex = 4;
            // 
            // userField
            // 
            this.userField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userField.Location = new System.Drawing.Point(149, 28);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(270, 23);
            this.userField.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.createFrame);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Sign in:";
            this.createFrame.ResumeLayout(false);
            this.createFrame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox createFrame;
        private System.Windows.Forms.Label incorrectMessage;
        private System.Windows.Forms.Button submit_Btn;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}