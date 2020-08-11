using MetroFramework.Forms;
using System.Windows.Forms;
using UniversalRichPresence.Core;
using UniversalRichPresence.Other;

namespace UniversalRichPresence.Forms
{
    public partial class MainForm : MetroForm
    {
        bool detailsModified;
        string lastItemValue;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            NotifyIconController.Setup();

            foreach (var detail in Globals.rpDetails)
                ProgramList.Items.Add(detail.Value.Executable);
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
                Globals.DisposeAll();
            else
            {
                e.Cancel = true;
                this.Hide();

                if (bool.Parse(Settings.GetValue("General", "FirstTime")))
                {
                    MainNotifyIcon.ShowBalloonTip(5, "URP In Background",
                        "Pressing X in the application doesn't close it, you can properly close it through the task icon. This info won't show up again", ToolTipIcon.Info);
                    Settings.ModifyValue("General", "FirstTime", "false");
                }
            }

            JSONCreation.WriteJSONFromRPDetails();
        }

        private void ProgramList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (detailsModified)
            {
                DialogResult result = MessageBox.Show(this, "You have unsaved changes! Would you like to save them?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    SaveSettings(lastItemValue);
            }

            RichPresenceDetails details = Globals.rpDetails[ProgramList.SelectedItem.ToString()];

            programNameTextbox.Text = details.Details;
            stateTextbox.Text = details.State;

            programNameTextbox.Enabled = true;
            stateTextbox.Enabled = true;
            saveButton.Enabled = true;

            detailsModified = false;
            lastItemValue = ProgramList.SelectedItem.ToString();
        }

        private void SaveSettings(string exe)
        {
            RichPresenceDetails details = Globals.rpDetails[exe];

            details.Details = programNameTextbox.Text;
            details.State = stateTextbox.Text;

            Globals.rpWorker.ForceTrigger();
        }

        private void CreateNewProgram(object sender, System.EventArgs e)
        {
            new CreateNewProgramDialog().Show();
        }

        private void DetailsChanged(object sender, System.EventArgs e)
        {
            detailsModified = true;
        }

        private void SaveSettingsWrapper(object sender, System.EventArgs e)
        {
            SaveSettings(ProgramList.SelectedItem.ToString());
        }
    }
}
