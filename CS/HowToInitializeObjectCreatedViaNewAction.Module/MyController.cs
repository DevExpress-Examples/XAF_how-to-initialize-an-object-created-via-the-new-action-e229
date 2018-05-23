using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

using DevExpress.ExpressApp.SystemModule;
namespace HowToInitializeObjectCreatedViaNewAction.Module {
   public partial class MyController : ViewController {
      public MyController() {
         InitializeComponent();
         RegisterActions(components);
      }

      private void MyController_FrameAssigned(object sender, EventArgs e) {
         NewObjectViewController standardController =
         Frame.GetController<NewObjectViewController>();
      standardController.ObjectCreated += new EventHandler<ObjectCreatedEventArgs>(standardController_ObjectCreated);
      }

      void standardController_ObjectCreated(object sender, ObjectCreatedEventArgs e) {
         ((Task)e.CreatedObject).StartDate = DateTime.Now;
      }
   }
} 