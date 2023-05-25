using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystemWatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            string text = e.OldName + " has been renamed to " + e.Name;
            listBox1.Items.Add(text);
        }

        private void fileSystemWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            const string FORMAT = "The {0} has changed in {1}";
            string text = string.Format(FORMAT, e.ChangeType, e.Name);
            listBox1.Items.Add(text);
        }
    }
}
