using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 parent)
        {
            InitializeComponent();
            f1 = parent;
            incorrectMessage.Visible = false;
        }

        private void submit_Btn_Click(object sender, EventArgs e)
        {
            String usernameInput = this.userField.Text;
            String passwordInput = this.passField.Text;
            if (!f1.signIn(usernameInput, passwordInput)) { incorrectMessage.Visible = true; return; }
            this.Close();
        }
    }
}
