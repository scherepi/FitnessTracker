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
    public partial class LoggedIn : Form
    {
        private String loggedInUser;
        public LoggedIn(String user)
        {
            InitializeComponent();
            this.loggedInUser = user;
            this.label1.Text = "Hi " + user + "!";
        }
    }
}
