using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Test2CopyFile
{
    public partial class MainForm : Form
    {
        private ListFilesCopies _lFilesCopies;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _lFilesCopies = new ListFilesCopies();
            var logicalDrives = Environment.GetLogicalDrives();
            cbListDrivesSource.Items.AddRange(logicalDrives);
            cbListDrivesDistanation.Items.AddRange(logicalDrives);
            if (cbListDrivesSource.Items.Count > 0)
                cbListDrivesSource.SelectedIndex = 0;

            if (cbListDrivesDistanation.Items.Count > 0)
                cbListDrivesDistanation.SelectedIndex = 0;
        }

        public string[] LoadListFiles(string path)
        {
            if (!Directory.Exists(path))
                return null;
            List<string> anyFiles = (from file in Directory.EnumerateDirectories(path)
                select Path.GetFileName(file)).ToList();
            anyFiles.AddRange(from file in Directory.EnumerateFiles(path)
                select Path.GetFileName(file));
            return anyFiles.ToArray();
        }

        private void cbListDrivesSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listFiles = LoadListFiles(cbListDrivesSource.Text);
            if (listFiles != null)
            {
                sourceListFile.Items.Clear();
                sourceListFile.Items.AddRange(listFiles);
            }
        }

        private void cbListDrivesDistanation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listFiles = LoadListFiles(cbListDrivesDistanation.Text);
            if (listFiles != null)
            {
                distanationListFile.Items.Clear();
                distanationListFile.Items.AddRange(listFiles);
            }
        }

        private void sourceListFile_DoubleClick(object sender, EventArgs e)
        {
            var pathString = cbListDrivesSource.Text + sourceListFile.Text;
            var listFiles = LoadListFiles(pathString);
            if (listFiles != null)
            {
                cbListDrivesSource.Text += sourceListFile.Text + @"\";
                sourceListFile.Items.Clear();
                sourceListFile.Items.AddRange(listFiles);
            }
        }

        private void distanationListFile_DoubleClick(object sender, EventArgs e)
        {
            var pathString = cbListDrivesDistanation.Text + distanationListFile.Text;
            var listFiles = LoadListFiles(pathString);
            if (listFiles != null)
            {
                cbListDrivesDistanation.Text += distanationListFile.Text + @"\";
                distanationListFile.Items.Clear();
                distanationListFile.Items.AddRange(listFiles);
            }
        }

        private void cbListDrivesSource_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int) Keys.Enter)
            {
                sourceListFile.Items.Clear();
                sourceListFile.Items.AddRange(LoadListFiles(cbListDrivesSource.Text));
            }
        }

        private void cbListDrivesDistanation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                distanationListFile.Items.Clear();
                distanationListFile.Items.AddRange(LoadListFiles(cbListDrivesDistanation.Text));
            }
        }

        private async void btnCopyFile_Click(object sender, EventArgs e)
        {
            string fileName = sourceListFile.Text;
            var fManager = new FileCopyManager();
            
            fManager.CopyCompleted += CloseWindowCopy;

            if (_lFilesCopies.IsDisposed)
                _lFilesCopies = new ListFilesCopies();


            _lFilesCopies.listCopies.Items.Add(cbListDrivesSource.Text + fileName + " -> " +
                                              cbListDrivesDistanation.Text + fileName);
            _lFilesCopies.Show();
            await fManager.FileCopy(cbListDrivesSource.Text + fileName, cbListDrivesDistanation.Text + fileName);
        }

        private void CloseWindowCopy(string nameFile)
        {
            //MessageBox.Show(@"Копирование завершено!", @"Копирование файла.");
            btnCopyFile.Invoke(new Action(() =>
            {
                if (_lFilesCopies.listCopies.Items.Contains(@nameFile))
                    _lFilesCopies.listCopies.Items.Remove(nameFile);

                if (_lFilesCopies.listCopies.Items.Count < 1)
                    _lFilesCopies.Close();
                    //_lFilesCopies.Hide();
            }));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_lFilesCopies.listCopies.Items.Count > 0)
                if (MessageBox.Show("Дождитесь окончания копирования всех файлов!", "Копирование файлов",
                        MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    e.Cancel = true;
        }
    }
}
