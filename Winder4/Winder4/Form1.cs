using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Winder4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PathEdit_TextChanged(object sender, EventArgs e)
        {
            var path = pathEdit.Text;
            path = path.Replace("\\", "/");
            pathEdit.Text = path;
        }

        private void PathEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RefreshList(pathEdit.Text);
            }
        }
        private void RefreshList(string targetPath)
        {
            filesListBox.Items.Clear();

            string[] dirs = Directory.GetDirectories(targetPath);
            string[] files = Directory.GetFiles(targetPath, "*", SearchOption.TopDirectoryOnly);

            foreach (var dir in dirs)
            {
                var dir2 = dir.Replace(targetPath, "").Replace("\\", "");
                filesListBox.Items.Add(dir2);
            }
            foreach (var file in files)
            {
                var file2 = file.Replace(targetPath, "").Replace("\\", "");
                filesListBox.Items.Add(file2);
            }
        }

        private void filesListBox_DoubleClick(object sender, EventArgs e)
        {
            if (filesListBox.SelectedIndex >= 0)
            {
                var name = filesListBox.Items[filesListBox.SelectedIndex];
                var targetPath = pathEdit.Text;
                var newPath = targetPath + "/" + name;
                if (Directory.Exists(newPath));
                {
                    RefreshList(newPath);
                    pathEdit.Text = newPath;
                }
            }
        }
    }
}
