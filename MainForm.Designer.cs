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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InstructionTextBox = new System.Windows.Forms.TextBox();
            this.UnitTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstructionTextBox
            // 
            this.InstructionTextBox.Location = new System.Drawing.Point(629, 12);
            this.InstructionTextBox.Multiline = true;
            this.InstructionTextBox.Name = "InstructionTextBox";
            this.InstructionTextBox.ReadOnly = true;
            this.InstructionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InstructionTextBox.Size = new System.Drawing.Size(461, 758);
            this.InstructionTextBox.TabIndex = 0;
            this.InstructionTextBox.Text = resources.GetString("InstructionTextBox.Text");
            // 
            // UnitTestButton
            // 
            this.UnitTestButton.Location = new System.Drawing.Point(548, 12);
            this.UnitTestButton.Name = "UnitTestButton";
            this.UnitTestButton.Size = new System.Drawing.Size(75, 23);
            this.UnitTestButton.TabIndex = 1;
            this.UnitTestButton.Text = "UnitTest";
            this.UnitTestButton.UseVisualStyleBackColor = true;
            this.UnitTestButton.Click += new System.EventHandler(this.UnitTestButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 782);
            this.Controls.Add(this.UnitTestButton);
            this.Controls.Add(this.InstructionTextBox);
            this.Name = "MainForm";
            this.Text = "MainForm  - Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InstructionTextBox;
        private System.Windows.Forms.Button UnitTestButton;
    }
}

