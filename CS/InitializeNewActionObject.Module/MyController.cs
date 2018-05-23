using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.Persistent.BaseImpl;

namespace HowToInitializeObjectCreatedViaNewAction.Module {
    public class MyController : ViewController {
        private NewObjectViewController controller;
        protected override void  OnActivated() {
            base.OnActivated();
            controller = Frame.GetController<NewObjectViewController>();
            controller.ObjectCreated += controller_ObjectCreated;
        }

        void controller_ObjectCreated(object sender, ObjectCreatedEventArgs e) {
            if (e.CreatedObject is Task) {
                ((Task)e.CreatedObject).StartDate = DateTime.Now;
            }
        }
        protected override void OnDeactivated() {
            if (controller != null) controller.ObjectCreated -= controller_ObjectCreated;
            base.OnDeactivated();
        }
    }
}
