Imports System.ComponentModel
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.SystemModule
Imports DevExpress.Persistent.BaseImpl

Namespace HowToInitializeObjectCreatedViaNewAction.Module
    Public Class MyController
        Inherits ViewController

        Private controller As NewObjectViewController
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            controller = Frame.GetController(Of NewObjectViewController)()
            AddHandler controller.ObjectCreated, AddressOf controller_ObjectCreated
        End Sub

        Private Sub controller_ObjectCreated(ByVal sender As Object, ByVal e As ObjectCreatedEventArgs)
            If TypeOf e.CreatedObject Is Task Then
                CType(e.CreatedObject, Task).StartDate = Date.Now
            End If
        End Sub
        Protected Overrides Sub OnDeactivated()
            If controller IsNot Nothing Then
                RemoveHandler controller.ObjectCreated, AddressOf controller_ObjectCreated
            End If
            MyBase.OnDeactivated()
        End Sub
    End Class
End Namespace
