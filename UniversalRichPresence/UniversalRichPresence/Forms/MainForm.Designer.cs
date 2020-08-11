namespace UniversalRichPresence.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ProgramList = new System.Windows.Forms.ListBox();
            this.programNameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.programNameLabel = new MetroFramework.Controls.MetroLabel();
            this.stateLabel = new MetroFramework.Controls.MetroLabel();
            this.stateTextbox = new MetroFramework.Controls.MetroTextBox();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.newProgramButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // MainNotifyIcon
            // 
            this.MainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MainNotifyIcon.Icon")));
            this.MainNotifyIcon.Text = "Universal Rich Presence";
            this.MainNotifyIcon.Visible = true;
            // 
            // ProgramList
            // 
            this.ProgramList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProgramList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProgramList.Font = new System.Drawing.Font("Greycliff CF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramList.ForeColor = System.Drawing.SystemColors.Info;
            this.ProgramList.FormattingEnabled = true;
            this.ProgramList.ItemHeight = 19;
            this.ProgramList.Location = new System.Drawing.Point(23, 72);
            this.ProgramList.Name = "ProgramList";
            this.ProgramList.Size = new System.Drawing.Size(266, 285);
            this.ProgramList.TabIndex = 0;
            this.ProgramList.SelectedIndexChanged += new System.EventHandler(this.ProgramList_SelectedIndexChanged);
            // 
            // programNameTextbox
            // 
            this.programNameTextbox.Enabled = false;
            this.programNameTextbox.Location = new System.Drawing.Point(433, 138);
            this.programNameTextbox.Name = "programNameTextbox";
            this.programNameTextbox.Size = new System.Drawing.Size(213, 24);
            this.programNameTextbox.Style = MetroFramework.MetroColorStyle.White;
            this.programNameTextbox.TabIndex = 1;
            this.programNameTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Location = new System.Drawing.Point(327, 140);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(102, 19);
            this.programNameLabel.Style = MetroFramework.MetroColorStyle.White;
            this.programNameLabel.TabIndex = 2;
            this.programNameLabel.Text = "Program Name";
            this.programNameLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(392, 170);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(38, 19);
            this.stateLabel.Style = MetroFramework.MetroColorStyle.White;
            this.stateLabel.TabIndex = 4;
            this.stateLabel.Text = "State";
            this.stateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // stateTextbox
            // 
            this.stateTextbox.Enabled = false;
            this.stateTextbox.Location = new System.Drawing.Point(433, 168);
            this.stateTextbox.Name = "stateTextbox";
            this.stateTextbox.Size = new System.Drawing.Size(213, 24);
            this.stateTextbox.Style = MetroFramework.MetroColorStyle.White;
            this.stateTextbox.TabIndex = 3;
            this.stateTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.stateTextbox.TextChanged += DetailsChanged;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(417, 220);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(137, 53);
            this.saveButton.Style = MetroFramework.MetroColorStyle.White;
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save Settings";
            this.saveButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.saveButton.Click += SaveSettingsWrapper;
            // 
            // newProgramButton
            // 
            this.newProgramButton.Location = new System.Drawing.Point(65, 375);
            this.newProgramButton.Name = "newProgramButton";
            this.newProgramButton.Size = new System.Drawing.Size(175, 52);
            this.newProgramButton.Style = MetroFramework.MetroColorStyle.White;
            this.newProgramButton.TabIndex = 8;
            this.newProgramButton.Text = "Add New Program";
            this.newProgramButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.newProgramButton.Click += new System.EventHandler(this.CreateNewProgram);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newProgramButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.stateTextbox);
            this.Controls.Add(this.programNameLabel);
            this.Controls.Add(this.programNameTextbox);
            this.Controls.Add(this.ProgramList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Universal Rich Presence";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.NotifyIcon MainNotifyIcon;
        private MetroFramework.Controls.MetroTextBox programNameTextbox;
        private MetroFramework.Controls.MetroLabel programNameLabel;
        private MetroFramework.Controls.MetroLabel stateLabel;
        private MetroFramework.Controls.MetroTextBox stateTextbox;
        private MetroFramework.Controls.MetroButton saveButton;
        private MetroFramework.Controls.MetroButton newProgramButton;
        public System.Windows.Forms.ListBox ProgramList;
    }
}

