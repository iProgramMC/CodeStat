/*
    CodeStat -- Calculate statistics for your code
    Copyright (C) 2021  iProgramInCpp

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeStat
{
    public partial class MainForm : Form
    {
        public bool m_shouldCancel = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    InputTextPath.Text = dlg.SelectedPath;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public bool FilePathHasExtensions(string path, string[] exts)
        {
            foreach (string ext in exts)
            {
                if (path.EndsWith("." + ext)) return true;
            }
            return false;
        }
        public int FilePathGetExtensionFromList(string path, string[] exts)
        {
            for (int i=0; i<exts.Length; i++)
            {
                if (path.EndsWith("." + exts[i])) return i;
            }
            return -1;
        }
        public bool m_runningTask = false;
        public void GetFiles(ref List<FileThing> files, string path, bool incSubdirs)
        {
            string extThing = InputTextExtension.Text;
            string[] exts = extThing.Split('|');
            try
            {
                string[] filess = Directory.GetFiles(path);
                if (filess.Length != 0)
                {
                    progressBar1.Minimum = 0;
                    progressBar1.Value = 0;
                    progressBar1.Maximum = filess.Length + 1;
                    foreach (string file in filess)
                    {
                        if (FilePathHasExtensions(file, exts))
                        {
                            if (m_shouldCancel) return;
                            LabelFile.Text = file;
                            //files.Add(file);
                            try
                            {
                                FileThing t = new FileThing();
                                t.fileName = file;
                                t.fileSize = (int)new FileInfo(file).Length;
                                string[] lines = File.ReadAllLines(file);
                                t.loc = lines.Length;
                                t.sloc = 0;
                                foreach (var line in lines)
                                    if (!string.IsNullOrWhiteSpace(line)/*TODO: add comment support too*/)
                                        t.sloc++;
                                files.Add(t);
                            }
                            catch (Exception ex) { ConsoleLog.Items.Add(ex.Message); }
                        }
                        if (m_shouldCancel) return;
                        progressBar1.Value++;
                        Application.DoEvents();
                    }
                }

                if (incSubdirs)
                {
                    string[] subdirs = Directory.GetDirectories(path);
                    foreach(string subdir in subdirs)
                    {
                        if (m_shouldCancel) return;
                        GetFiles(ref files, subdir, incSubdirs);
                        if (m_shouldCancel) return;
                        Application.DoEvents();
                    }
                }
            }
            catch (Exception ex) { ConsoleLog.Items.Add(ex.Message); }
            Application.DoEvents();
        }

        void CalculateTotalStats(ref List<FileThing> fileThings)
        {
            int totalLOC = 0, totalSLOC = 0, totalFileSize = 0;
            var exts = InputTextExtension.Text.Split('|');
            int extCount = exts.Length;
            int[] totalLocForExts = new int[extCount];
            int[] totalSLocForExts = new int[extCount];
            int[] totalSizeForExts = new int[extCount];
            progressBar1.Minimum = 0;
            progressBar1.Maximum = fileThings.Count+1;
            progressBar1.Value = 0;
            foreach (FileThing thing in fileThings)
            {
                if (m_shouldCancel) return;
                LabelFile.Text = thing.fileName;

                totalLOC += thing.loc;
                totalSLOC += thing.sloc;
                totalFileSize += thing.fileSize;

                int ext = FilePathGetExtensionFromList(thing.fileName, exts);
                if (ext != -1)
                {
                    totalLocForExts[ext] += thing.loc;
                    totalSLocForExts[ext] += thing.sloc;
                    totalSizeForExts[ext] += thing.fileSize;
                }

                progressBar1.Value++;
                if (m_shouldCancel) return;
                Application.DoEvents();
            }

            //log everything
            StatsList.Items.Add($"Total file size: {totalFileSize}");
            StatsList.Items.Add($"Total non-empty LOC: {totalSLOC}");
            StatsList.Items.Add($"Total lines of code: {totalLOC}");
            StatsList.Items.Add("===================================================================");
            for (int i=0; i<extCount; i++)
            {
                StatsList.Items.Add($"[{exts[i]}] total file size: {totalSizeForExts[i]}");
                StatsList.Items.Add($"[{exts[i]}] total non-empty LOC: {totalSLocForExts[i]}");
                StatsList.Items.Add($"[{exts[i]}] total lines of code (LOC): {totalLocForExts[i]}");
            }
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            m_runningTask = true;
            //get files
            List<FileThing> files = new List<FileThing>();

            StatsList.Items.Clear();
            LabelStep.Text = "Indexing files...";
            GetFiles(ref files, InputTextPath.Text, CheckIncludeSubdirs.Checked);
            LabelStep.Text = "Calculating total stats...";
            CalculateTotalStats(ref files);
            LabelStep.Text = "Done!";
            LabelFile.Text = "";
            ButtonCancel.Enabled = true;
            ButtonCancel.Text = "Cancel";
            m_shouldCancel = false;
            m_runningTask = false;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (m_runningTask)
            {
                m_shouldCancel = true;
                ButtonCancel.Enabled = false;
                ButtonCancel.Text = "Cancelling...";
            }
        }
    }
    public class FileThing
    {
        public string fileName;
        public int loc, sloc;//lines of code, source lines of code
        public int fileSize;
    }
}
