using System;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace HowToInitializeObjectCreatedViaNewAction.Module.Web {
   [ToolboxItemFilter("Xaf.Platform.Web")]
   public sealed partial class HowToInitializeObjectCreatedViaNewActionAspNetModule : ModuleBase {
      public HowToInitializeObjectCreatedViaNewActionAspNetModule() {
         InitializeComponent();
      }
   }
}
