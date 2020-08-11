using MetroFramework.Forms;
using System.Windows.Forms;
using UniversalRichPresence.Core;
using UniversalRichPresence.Other;

namespace UniversalRichPresence.Forms
{
    public partial class CreateNewProgramDialog : MetroForm
    {
        public CreateNewProgramDialog()
        {
            InitializeComponent();
        }

        private void AddProgram(object sender, System.EventArgs e)
        {
            new RichPresenceDetails(executableTextbox.Text, programNameTextbox.Text, stateTextbox.Text);
            Globals.mainForm.ProgramList.Items.Add(executableTextbox.Text);

            Dispose();
        }
    }
}
