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
        public Form1()
        {
            InitializeComponent();
            // Time to first check for our "database" file, and then create it if it's not there.
            if (File.Exists(databaseName)) {
                Console.WriteLine("Database valid!");  
            } else {
                using (FileStream fs = new FileStream(databaseName, FileMode.Create)) {
                    using (StreamWriter sw = new StreamWriter(fs)) {
                        sw.WriteLine("DATABASE START");
                    }
                }
            }

        }


    }
}
