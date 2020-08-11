namespace UniversalRichPresence.Forms
{
    partial class CreateNewProgramDialog
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.stateTextbox = new MetroFramework.Controls.MetroTextBox();
            this.programNameLabel = new MetroFramework.Controls.MetroLabel();
            this.programNameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.executableNameLabel = new MetroFramework.Controls.MetroLabel();
            this.executableTextbox = new MetroFramework.Controls.MetroTextBox();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(117, 164);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "State";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // stateTextbox
            // 
            this.stateTextbox.Location = new System.Drawing.Point(158, 162);
            this.stateTextbox.Name = "stateTextbox";
            this.stateTextbox.Size = new System.Drawing.Size(213, 24);
            this.stateTextbox.Style = MetroFramework.MetroColorStyle.White;
            this.stateTextbox.TabIndex = 7;
            this.stateTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Location = new System.Drawing.Point(52, 134);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(102, 19);
            this.programNameLabel.Style = MetroFramework.MetroColorStyle.White;
            this.programNameLabel.TabIndex = 6;
            this.programNameLabel.Text = "Program Name";
            this.programNameLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // programNameTextbox
            // 
            this.programNameTextbox.Location = new System.Drawing.Point(158, 132);
            this.programNameTextbox.Name = "programNameTextbox";
            this.programNameTextbox.Size = new System.Drawing.Size(213, 24);
            this.programNameTextbox.Style = MetroFramework.MetroColorStyle.White;
            this.programNameTextbox.TabIndex = 5;
            this.programNameTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // executableNameLabel
            // 
            this.executableNameLabel.AutoSize = true;
            this.executableNameLabel.Location = new System.Drawing.Point(43, 104);
            this.executableNameLabel.Name = "executableNameLabel";
            this.executableNameLabel.Size = new System.Drawing.Size(111, 19);
            this.executableNameLabel.Style = MetroFramework.MetroColorStyle.White;
            this.executableNameLabel.TabIndex = 10;
            this.executableNameLabel.Text = "Executable Name";
            this.executableNameLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // executableTextbox
            // 
            this.executableTextbox.Location = new System.Drawing.Point(158, 102);
            this.executableTextbox.Name = "executableTextbox";
            this.executableTextbox.Size = new System.Drawing.Size(213, 24);
            this.executableTextbox.Style = MetroFramework.MetroColorStyle.White;
            this.executableTextbox.TabIndex = 9;
            this.executableTextbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(139, 221);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(143, 39);
            this.addButton.Style = MetroFramework.MetroColorStyle.White;
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.addButton.Click += new System.EventHandler(this.AddProgram);
            // 
            // CreateNewProgramDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 296);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.executableNameLabel);
            this.Controls.Add(this.executableTextbox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.stateTextbox);
            this.Controls.Add(this.programNameLabel);
            this.Controls.Add(this.programNameTextbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateNewProgramDialog";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Add New Program";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox stateTextbox;
        private MetroFramework.Controls.MetroLabel programNameLabel;
        private MetroFramework.Controls.MetroTextBox programNameTextbox;
        private MetroFramework.Controls.MetroLabel executableNameLabel;
        private MetroFramework.Controls.MetroTextBox executableTextbox;
        private MetroFramework.Controls.MetroButton addButton;
    }
}