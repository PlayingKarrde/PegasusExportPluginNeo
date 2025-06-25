using System.Drawing;
using Unbroken.LaunchBox.Plugins;

namespace PegasusExportPlugin
{
    class ProgramEntry : ISystemMenuItemPlugin
    {
        public string Caption => "Export to Pegasus";

        public Image IconImage => null;

        public bool ShowInLaunchBox => true;

        public bool ShowInBigBox => false;

        public bool AllowInBigBoxWhenLocked => false;

        public void OnSelected()
        {
            using(var frmPegasusExport = new frmPegasusExport())
            {
                frmPegasusExport.ShowDialog();
            }
        }
       
    }
}
