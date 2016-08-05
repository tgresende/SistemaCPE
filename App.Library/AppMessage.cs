using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.Library
{
    public class AppMessage
    {
        public static void Show(string Message, string Caption = "DuoSys")
        {
            FlyoutAction action = new FlyoutAction() { Caption = Caption, Description = Message };
            FlyoutCommand command1 = new FlyoutCommand() { Text = "OK", Result = DialogResult.OK };
            action.Commands.Add(command1);
            FlyoutProperties properties = new FlyoutProperties();
            properties.ButtonSize = new Size(200, 40);
            properties.Style = DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutStyle.MessageBox;
            FlyoutDialog.Show(Application.OpenForms[0], action, properties);
        }
    }
}


/*private static bool canCloseFunc(DialogResult parameter) {
    return parameter != DialogResult.Cancel;
}

private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
    DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction action = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() { Caption = "Confirm", Description = "Close the application?" };
    Predicate<DialogResult> predicate = canCloseFunc;
    DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "Close", Result = System.Windows.Forms.DialogResult.Yes };
    DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand command2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() { Text = "Cancel", Result = System.Windows.Forms.DialogResult.No };
    action.Commands.Add(command1);
    action.Commands.Add(command2);
    FlyoutProperties properties = new FlyoutProperties();
    properties.ButtonSize = new Size(100, 40);
    properties.Style = FlyoutStyle.MessageBox;
    if (FlyoutDialog.Show(this, action, properties, predicate) == System.Windows.Forms.DialogResult.Yes) e.Cancel = false;
    else e.Cancel = true;
}*/
