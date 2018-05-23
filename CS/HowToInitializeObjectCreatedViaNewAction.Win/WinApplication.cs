using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;

namespace HowToInitializeObjectCreatedViaNewAction.Win {
    public partial class HowToInitializeObjectCreatedViaNewActionWindowsFormsApplication : WinApplication {
        public HowToInitializeObjectCreatedViaNewActionWindowsFormsApplication() {
            InitializeComponent();
        }

        private void HowToInitializeObjectCreatedViaNewActionWindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
			e.Updater.Update();
			e.Handled = true;
        }
    }
}
