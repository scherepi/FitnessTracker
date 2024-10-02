using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        private const String databaseName = "Test.data";
        private Dictionary<String, String> accounts = new Dictionary<String, String>();
        public Form1()
        {
            InitializeComponent();
            // Time to first check for our "database" file, and then create it if it's not there.
            if (File.Exists(databaseName)) {
                Console.WriteLine("Database valid!");
                // Now we read our values and put them into our dictionary to work with them easily.
                using (FileStream fs = new FileStream(databaseName, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line;
                        // First we double-check that we're reading the database, just to be sure.
                        Console.WriteLine(sr.ReadLine()); // This should output DATABASE START
                        // Now we keep reading until there's no more input, making each entry a key-value pair in our dictionary.
                        while ((line = sr.ReadLine()) != null)
                        {
                            string user = line.Split(',')[0];
                            string pass = line.Split(',')[1];
                            accounts.Add(user, pass);
                        }
                    }
                }
            } else {
                Console.WriteLine("Database missing, creating now.");
                using (FileStream fs = new FileStream(databaseName, FileMode.Create)) {
                    using (StreamWriter sw = new StreamWriter(fs)) {
                        sw.WriteLine("DATABASE START");
                    }
                }
            }

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // Open the create account dialog when the button is clicked, and don't let the user interact with the main form until the process is complete.
            Form3 f3 = new Form3(this);
            f3.ShowDialog();
        }
        public void createAccount(string username, string password)
        {
            // First, just add it to the current dictionary.
            this.accounts.Add(username, password);
            // We can assume that the database exists, because everything was checked and set up when the form was initalized.
            // We would check here whether the account being created already exists, but we're actually gonna do that in our checkAccount method.
            // We can assume when this function is called that all circumstances are correct for account creation.
            using (FileStream fs = new FileStream(databaseName, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    // IMPORTANT: we're gonna have to sanitize the input to the create account form to make sure you can't use commas. otherwise, whole database breaks.
                    sw.WriteLine(username + "," + password + "");
                }
            }
        }
        public Boolean accountExists(string username)
        {
            // literally just check whether the an entry already exists with that key.
            return this.accounts.ContainsKey(username);
        }
    }
}
