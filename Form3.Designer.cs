namespace FitnessTracker
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.submit_Btn = new System.Windows.Forms.Button();
            this.createFrame = new System.Windows.Forms.GroupBox();
            this.idMessage = new System.Windows.Forms.Label();
            this.emptyMessage = new System.Windows.Forms.Label();
            this.sorryMessage = new System.Windows.Forms.Label();
            this.createFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create your account!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // userField
            // 
            this.userField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userField.Location = new System.Drawing.Point(224, 43);
            this.userField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(403, 30);
            this.userField.TabIndex = 3;
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.Location = new System.Drawing.Point(224, 120);
            this.passField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passField.Name = "passField";
            this.passField.PasswordChar = '*';
            this.passField.Size = new System.Drawing.Size(403, 30);
            this.passField.TabIndex = 4;
            // 
            // submit_Btn
            // 
            this.submit_Btn.Location = new System.Drawing.Point(224, 200);
            this.submit_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submit_Btn.Name = "submit_Btn";
            this.submit_Btn.Size = new System.Drawing.Size(405, 63);
            this.submit_Btn.TabIndex = 5;
            this.submit_Btn.Text = "Start your fitness journey!";
            this.submit_Btn.UseVisualStyleBackColor = true;
            this.submit_Btn.Click += new System.EventHandler(this.submit_Btn_Click);
            // 
            // createFrame
            // 
            this.createFrame.Controls.Add(this.idMessage);
            this.createFrame.Controls.Add(this.submit_Btn);
            this.createFrame.Controls.Add(this.passField);
            this.createFrame.Controls.Add(this.userField);
            this.createFrame.Controls.Add(this.label3);
            this.createFrame.Controls.Add(this.label2);
            this.createFrame.Location = new System.Drawing.Point(156, 191);
            this.createFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createFrame.Name = "createFrame";
            this.createFrame.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createFrame.Size = new System.Drawing.Size(678, 318);
            this.createFrame.TabIndex = 6;
            this.createFrame.TabStop = false;
            // 
            // idMessage
            // 
            this.idMessage.AutoSize = true;
            this.idMessage.Location = new System.Drawing.Point(328, 169);
            this.idMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idMessage.Name = "idMessage";
            this.idMessage.Size = new System.Drawing.Size(205, 20);
            this.idMessage.TabIndex = 9;
            this.idMessage.Text = "That account already exists!";
            // 
            // emptyMessage
            // 
            this.emptyMessage.AutoSize = true;
            this.emptyMessage.Location = new System.Drawing.Point(436, 532);
            this.emptyMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emptyMessage.Name = "emptyMessage";
            this.emptyMessage.Size = new System.Drawing.Size(253, 20);
            this.emptyMessage.TabIndex = 7;
            this.emptyMessage.Text = "You can\'t make an empty account!";
            // 
            // sorryMessage
            // 
            this.sorryMessage.AutoSize = true;
            this.sorryMessage.Location = new System.Drawing.Point(414, 532);
            this.sorryMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sorryMessage.Name = "sorryMessage";
            this.sorryMessage.Size = new System.Drawing.Size(312, 20);
            this.sorryMessage.TabIndex = 8;
            this.sorryMessage.Text = "Please try again without special characters!";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(999, 692);
            this.Controls.Add(this.sorryMessage);
            this.Controls.Add(this.emptyMessage);
            this.Controls.Add(this.createFrame);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Account Creation";
            this.createFrame.ResumeLayout(false);
            this.createFrame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button submit_Btn;
        private System.Windows.Forms.GroupBox createFrame;
        private System.Windows.Forms.Label emptyMessage;
        private System.Windows.Forms.Label sorryMessage;
        private System.Windows.Forms.Label idMessage;
    }
}