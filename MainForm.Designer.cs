namespace CodeStat
{
    partial class MainForm
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
            this.LabelPath = new System.Windows.Forms.Label();
            this.InputTextPath = new System.Windows.Forms.TextBox();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.CheckIncludeSubdirs = new System.Windows.Forms.CheckBox();
            this.ConsoleLog = new System.Windows.Forms.ListBox();
            this.LabelStep = new System.Windows.Forms.Label();
            this.LabelFile = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GroupBoxStats = new System.Windows.Forms.GroupBox();
            this.StatsList = new System.Windows.Forms.ListBox();
            this.LabelExt = new System.Windows.Forms.Label();
            this.InputTextExtension = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.GroupBoxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelPath
            // 
            this.LabelPath.AutoSize = true;
            this.LabelPath.Location = new System.Drawing.Point(12, 17);
            this.LabelPath.Name = "LabelPath";
            this.LabelPath.Size = new System.Drawing.Size(32, 13);
            this.LabelPath.TabIndex = 0;
            this.LabelPath.Text = "Path:";
            // 
            // InputTextPath
            // 
            this.InputTextPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextPath.Location = new System.Drawing.Point(50, 14);
            this.InputTextPath.Name = "InputTextPath";
            this.InputTextPath.Size = new System.Drawing.Size(421, 20);
            this.InputTextPath.TabIndex = 2;
            this.InputTextPath.Text = "C:\\";
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBrowse.Location = new System.Drawing.Point(477, 12);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(25, 23);
            this.ButtonBrowse.TabIndex = 3;
            this.ButtonBrowse.Text = "...";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCalculate.Location = new System.Drawing.Point(12, 405);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(490, 44);
            this.ButtonCalculate.TabIndex = 4;
            this.ButtonCalculate.Text = "Calculate statistics!";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // CheckIncludeSubdirs
            // 
            this.CheckIncludeSubdirs.AutoSize = true;
            this.CheckIncludeSubdirs.Checked = true;
            this.CheckIncludeSubdirs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckIncludeSubdirs.Location = new System.Drawing.Point(15, 40);
            this.CheckIncludeSubdirs.Name = "CheckIncludeSubdirs";
            this.CheckIncludeSubdirs.Size = new System.Drawing.Size(147, 17);
            this.CheckIncludeSubdirs.TabIndex = 5;
            this.CheckIncludeSubdirs.Text = "Include subdirectories too";
            this.CheckIncludeSubdirs.UseVisualStyleBackColor = true;
            // 
            // ConsoleLog
            // 
            this.ConsoleLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsoleLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleLog.FormattingEnabled = true;
            this.ConsoleLog.ItemHeight = 14;
            this.ConsoleLog.Location = new System.Drawing.Point(15, 311);
            this.ConsoleLog.Name = "ConsoleLog";
            this.ConsoleLog.Size = new System.Drawing.Size(487, 88);
            this.ConsoleLog.TabIndex = 6;
            // 
            // LabelStep
            // 
            this.LabelStep.AutoSize = true;
            this.LabelStep.Location = new System.Drawing.Point(12, 60);
            this.LabelStep.Name = "LabelStep";
            this.LabelStep.Size = new System.Drawing.Size(24, 13);
            this.LabelStep.TabIndex = 7;
            this.LabelStep.Text = "Idle";
            // 
            // LabelFile
            // 
            this.LabelFile.AutoSize = true;
            this.LabelFile.Location = new System.Drawing.Point(12, 81);
            this.LabelFile.Name = "LabelFile";
            this.LabelFile.Size = new System.Drawing.Size(0, 13);
            this.LabelFile.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(15, 97);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(403, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // GroupBoxStats
            // 
            this.GroupBoxStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxStats.Controls.Add(this.StatsList);
            this.GroupBoxStats.Location = new System.Drawing.Point(15, 126);
            this.GroupBoxStats.Name = "GroupBoxStats";
            this.GroupBoxStats.Size = new System.Drawing.Size(487, 179);
            this.GroupBoxStats.TabIndex = 10;
            this.GroupBoxStats.TabStop = false;
            this.GroupBoxStats.Text = "Statistics";
            // 
            // StatsList
            // 
            this.StatsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatsList.FormattingEnabled = true;
            this.StatsList.Location = new System.Drawing.Point(3, 16);
            this.StatsList.Name = "StatsList";
            this.StatsList.Size = new System.Drawing.Size(481, 160);
            this.StatsList.TabIndex = 0;
            // 
            // LabelExt
            // 
            this.LabelExt.AutoSize = true;
            this.LabelExt.Location = new System.Drawing.Point(212, 41);
            this.LabelExt.Name = "LabelExt";
            this.LabelExt.Size = new System.Drawing.Size(53, 13);
            this.LabelExt.TabIndex = 11;
            this.LabelExt.Text = "Extension";
            // 
            // InputTextExtension
            // 
            this.InputTextExtension.Location = new System.Drawing.Point(271, 38);
            this.InputTextExtension.MaxLength = 128;
            this.InputTextExtension.Name = "InputTextExtension";
            this.InputTextExtension.Size = new System.Drawing.Size(200, 20);
            this.InputTextExtension.TabIndex = 12;
            this.InputTextExtension.Text = "cs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "(use \'|\' if you want to analyze multiple extensions)";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.Location = new System.Drawing.Point(424, 97);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 14;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 461);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputTextExtension);
            this.Controls.Add(this.LabelExt);
            this.Controls.Add(this.GroupBoxStats);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LabelFile);
            this.Controls.Add(this.LabelStep);
            this.Controls.Add(this.ConsoleLog);
            this.Controls.Add(this.CheckIncludeSubdirs);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.ButtonBrowse);
            this.Controls.Add(this.InputTextPath);
            this.Controls.Add(this.LabelPath);
            this.Name = "MainForm";
            this.Text = "CodeStat V1.0 by iProgramInCpp - Calculate statistics on your code";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GroupBoxStats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPath;
        private System.Windows.Forms.TextBox InputTextPath;
        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.CheckBox CheckIncludeSubdirs;
        private System.Windows.Forms.ListBox ConsoleLog;
        private System.Windows.Forms.Label LabelStep;
        private System.Windows.Forms.Label LabelFile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox GroupBoxStats;
        private System.Windows.Forms.ListBox StatsList;
        private System.Windows.Forms.Label LabelExt;
        private System.Windows.Forms.TextBox InputTextExtension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonCancel;
    }
}

