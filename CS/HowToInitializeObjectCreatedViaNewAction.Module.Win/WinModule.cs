using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace HowToInitializeObjectCreatedViaNewAction.Module.Win {
   [ToolboxItemFilter("Xaf.Platform.Win")]
   public sealed partial class HowToInitializeObjectCreatedViaNewActionWindowsFormsModule : ModuleBase {
      public HowToInitializeObjectCreatedViaNewActionWindowsFormsModule() {
         InitializeComponent();
      }
   }
}
