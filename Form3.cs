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
    public partial class Form3 : Form
    {
        Form1 f1;
        public Form3(Form1 parent)
        {
            InitializeComponent();
            f1 = parent;
            emptyMessage.Visible = false;
            sorryMessage.Visible = false;
            idMessage.Visible = false;
        }

        private void submit_Btn_Click(object sender, EventArgs e)
        {
            string user = this.userField.Text;
            Console.WriteLine("USER FIELD: " + user);
            string pass = this.passField.Text;
            Console.WriteLine("PASSWORD FIELD: " + pass);
            if (user == "" || pass == "") {
                // We don't want empty input! Tell the user that and don't do anything.
                Console.WriteLine("empty input");
                sorryMessage.Visible = false;
                idMessage.Visible = false;
                emptyMessage.Visible = true;
                return;
            }
            if (user.Contains(",") || pass.Contains(",")) {
                // Commas will break our database. Don't do anything! 
                Console.WriteLine("DESTRUCTIVE INPUT");
                emptyMessage.Visible = false;
                idMessage.Visible = false;
                sorryMessage.Visible = true;
                return;
            }
            // If the input is valid, now we have to check if that account already exists.
            if (f1.accountExists(user)) { emptyMessage.Visible = false; sorryMessage.Visible = false; idMessage.Visible = true;  return; }
            // Finally, once we've made all those checks, we can try to create an account for the provided credentials.
            f1.createAccount(user, pass);
            this.Close();
        }
    }
}
