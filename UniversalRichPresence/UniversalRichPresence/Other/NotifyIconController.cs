using System.Diagnostics;
using System.Windows.Forms;
using UniversalRichPresence.Core;

namespace UniversalRichPresence.Other
{
    public class NotifyIconController
    {
        static ToolStripItem viewToggle;
        static ToolStripItem exitButton;

        public static void Setup()
        {
            var taskIconMenu = new ContextMenuStrip();
            taskIconMenu.Items.Add("Show");
            taskIconMenu.Items.Add("Exit");

            Globals.mainForm.MainNotifyIcon.ContextMenuStrip = taskIconMenu;
            viewToggle = Globals.mainForm.MainNotifyIcon.ContextMenuStrip.Items[0];
            exitButton = Globals.mainForm.MainNotifyIcon.ContextMenuStrip.Items[1];

            Globals.mainForm.MainNotifyIcon.ContextMenuStrip.Opening += NotifyMenuOpen;
            viewToggle.Click += FormViewToggleClick;
            exitButton.Click += FormExitClick;
        }

        private static void NotifyMenuOpen(object sender, System.EventArgs e)
        {
            if (Globals.mainForm.Visible)
                viewToggle.Text = "Hide";
            else
                viewToggle.Text = "Show";
        }

        private static void FormViewToggleClick(object sender, System.EventArgs e)
        {
            if (viewToggle.Text == "Hide")
                Globals.mainForm.Hide();
            else
                Globals.mainForm.Show();
        }

        private static void FormExitClick(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
