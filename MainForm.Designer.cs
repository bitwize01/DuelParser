namespace DuelParser
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
            this.textbLoadFile = new System.Windows.Forms.TextBox();
            this.butSelectFile = new System.Windows.Forms.Button();
            this.textbLogFile = new System.Windows.Forms.TextBox();
            this.butScout = new System.Windows.Forms.Button();
            this.textbOutput = new System.Windows.Forms.TextBox();
            this.checklbCallers = new System.Windows.Forms.CheckedListBox();
            this.butSaveToDB = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFullDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predictorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPredictorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelChatLog = new System.Windows.Forms.Label();
            this.labelSelectCallers = new System.Windows.Forms.Label();
            this.labelScoutedOutput = new System.Windows.Forms.Label();
            this.butParse = new System.Windows.Forms.Button();
            this.labelSelectSport = new System.Windows.Forms.Label();
            this.combobSelectSport = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbLoadFile
            // 
            this.textbLoadFile.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textbLoadFile.Location = new System.Drawing.Point(36, 41);
            this.textbLoadFile.Name = "textbLoadFile";
            this.textbLoadFile.Size = new System.Drawing.Size(358, 20);
            this.textbLoadFile.TabIndex = 1;
            this.textbLoadFile.Text = "Select a file to parse...";
            // 
            // butSelectFile
            // 
            this.butSelectFile.Location = new System.Drawing.Point(440, 38);
            this.butSelectFile.Name = "butSelectFile";
            this.butSelectFile.Size = new System.Drawing.Size(158, 23);
            this.butSelectFile.TabIndex = 2;
            this.butSelectFile.Text = "Select File";
            this.butSelectFile.UseVisualStyleBackColor = true;
            this.butSelectFile.Click += new System.EventHandler(this.butSelectFile_Click);
            // 
            // textbLogFile
            // 
            this.textbLogFile.Location = new System.Drawing.Point(37, 277);
            this.textbLogFile.Multiline = true;
            this.textbLogFile.Name = "textbLogFile";
            this.textbLogFile.Size = new System.Drawing.Size(357, 375);
            this.textbLogFile.TabIndex = 3;
            this.textbLogFile.TextChanged += new System.EventHandler(this.textbLogFile_TextChanged);
            // 
            // butScout
            // 
            this.butScout.Location = new System.Drawing.Point(440, 277);
            this.butScout.Name = "butScout";
            this.butScout.Size = new System.Drawing.Size(158, 23);
            this.butScout.TabIndex = 4;
            this.butScout.Text = "Scout";
            this.butScout.UseVisualStyleBackColor = true;
            this.butScout.Click += new System.EventHandler(this.butScout_Click);
            // 
            // textbOutput
            // 
            this.textbOutput.Location = new System.Drawing.Point(645, 62);
            this.textbOutput.Multiline = true;
            this.textbOutput.Name = "textbOutput";
            this.textbOutput.ReadOnly = true;
            this.textbOutput.Size = new System.Drawing.Size(610, 590);
            this.textbOutput.TabIndex = 5;
            // 
            // checklbCallers
            // 
            this.checklbCallers.FormattingEnabled = true;
            this.checklbCallers.Items.AddRange(new object[] {
            "Awkward",
            "Claire",
            "Peaches",
            "Shadow"});
            this.checklbCallers.Location = new System.Drawing.Point(37, 96);
            this.checklbCallers.MultiColumn = true;
            this.checklbCallers.Name = "checklbCallers";
            this.checklbCallers.Size = new System.Drawing.Size(357, 94);
            this.checklbCallers.Sorted = true;
            this.checklbCallers.TabIndex = 6;
            this.checklbCallers.SelectedIndexChanged += new System.EventHandler(this.checklbCallers_SelectedIndexChanged);
            // 
            // butSaveToDB
            // 
            this.butSaveToDB.Location = new System.Drawing.Point(440, 629);
            this.butSaveToDB.Name = "butSaveToDB";
            this.butSaveToDB.Size = new System.Drawing.Size(158, 23);
            this.butSaveToDB.TabIndex = 7;
            this.butSaveToDB.Text = "Save";
            this.butSaveToDB.UseVisualStyleBackColor = true;
            this.butSaveToDB.Click += new System.EventHandler(this.butSaveToDB_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.predictorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFullDBToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFullDBToolStripMenuItem
            // 
            this.loadFullDBToolStripMenuItem.Name = "loadFullDBToolStripMenuItem";
            this.loadFullDBToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadFullDBToolStripMenuItem.Text = "Load Full DB";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // predictorToolStripMenuItem
            // 
            this.predictorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPredictorToolStripMenuItem});
            this.predictorToolStripMenuItem.Name = "predictorToolStripMenuItem";
            this.predictorToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.predictorToolStripMenuItem.Text = "Predictor";
            // 
            // loadPredictorToolStripMenuItem
            // 
            this.loadPredictorToolStripMenuItem.Name = "loadPredictorToolStripMenuItem";
            this.loadPredictorToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.loadPredictorToolStripMenuItem.Text = "Load Predictor";
            // 
            // labelChatLog
            // 
            this.labelChatLog.AutoSize = true;
            this.labelChatLog.Location = new System.Drawing.Point(34, 261);
            this.labelChatLog.Name = "labelChatLog";
            this.labelChatLog.Size = new System.Drawing.Size(50, 13);
            this.labelChatLog.TabIndex = 9;
            this.labelChatLog.Text = "Chat Log";
            // 
            // labelSelectCallers
            // 
            this.labelSelectCallers.AutoSize = true;
            this.labelSelectCallers.Location = new System.Drawing.Point(34, 80);
            this.labelSelectCallers.Name = "labelSelectCallers";
            this.labelSelectCallers.Size = new System.Drawing.Size(68, 13);
            this.labelSelectCallers.TabIndex = 10;
            this.labelSelectCallers.Text = "SelectCallers";
            // 
            // labelScoutedOutput
            // 
            this.labelScoutedOutput.AutoSize = true;
            this.labelScoutedOutput.Location = new System.Drawing.Point(645, 47);
            this.labelScoutedOutput.Name = "labelScoutedOutput";
            this.labelScoutedOutput.Size = new System.Drawing.Size(82, 13);
            this.labelScoutedOutput.TabIndex = 11;
            this.labelScoutedOutput.Text = "Scouted Output";
            // 
            // butParse
            // 
            this.butParse.Location = new System.Drawing.Point(440, 223);
            this.butParse.Name = "butParse";
            this.butParse.Size = new System.Drawing.Size(158, 23);
            this.butParse.TabIndex = 12;
            this.butParse.Text = "Parse";
            this.butParse.UseVisualStyleBackColor = true;
            this.butParse.Click += new System.EventHandler(this.butParse_Click);
            // 
            // labelSelectSport
            // 
            this.labelSelectSport.AutoSize = true;
            this.labelSelectSport.Location = new System.Drawing.Point(34, 207);
            this.labelSelectSport.Name = "labelSelectSport";
            this.labelSelectSport.Size = new System.Drawing.Size(65, 13);
            this.labelSelectSport.TabIndex = 14;
            this.labelSelectSport.Text = "Select Sport";
            // 
            // combobSelectSport
            // 
            this.combobSelectSport.FormattingEnabled = true;
            this.combobSelectSport.Items.AddRange(new object[] {
            "Fists",
            "Magic",
            "Swords"});
            this.combobSelectSport.Location = new System.Drawing.Point(35, 223);
            this.combobSelectSport.Name = "combobSelectSport";
            this.combobSelectSport.Size = new System.Drawing.Size(359, 21);
            this.combobSelectSport.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 670);
            this.Controls.Add(this.combobSelectSport);
            this.Controls.Add(this.labelSelectSport);
            this.Controls.Add(this.butParse);
            this.Controls.Add(this.labelScoutedOutput);
            this.Controls.Add(this.labelSelectCallers);
            this.Controls.Add(this.labelChatLog);
            this.Controls.Add(this.butSaveToDB);
            this.Controls.Add(this.checklbCallers);
            this.Controls.Add(this.textbOutput);
            this.Controls.Add(this.butScout);
            this.Controls.Add(this.textbLogFile);
            this.Controls.Add(this.butSelectFile);
            this.Controls.Add(this.textbLoadFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Duel Parser";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbLoadFile;
        private System.Windows.Forms.Button butSelectFile;
        private System.Windows.Forms.TextBox textbLogFile;
        private System.Windows.Forms.Button butScout;
        private System.Windows.Forms.TextBox textbOutput;
        private System.Windows.Forms.CheckedListBox checklbCallers;
        private System.Windows.Forms.Button butSaveToDB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFullDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predictorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPredictorToolStripMenuItem;
        private System.Windows.Forms.Label labelChatLog;
        private System.Windows.Forms.Label labelSelectCallers;
        private System.Windows.Forms.Label labelScoutedOutput;
        private System.Windows.Forms.Button butParse;
        private System.Windows.Forms.Label labelSelectSport;
        private System.Windows.Forms.ComboBox combobSelectSport;

    }
}

