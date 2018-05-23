Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.SystemModule

Public Class MyController
	Inherits DevExpress.ExpressApp.ViewController

	Public Sub New()
		MyBase.New()

		'This call is required by the Component Designer.
		InitializeComponent()
		RegisterActions(components) 

	End Sub

    Private Sub MyController_FrameAssigned(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FrameAssigned
        Dim standardController As NewObjectViewController = _
         Frame.GetController(Of NewObjectViewController)()
        AddHandler standardController.ObjectCreated, AddressOf standardController_ObjectCreated
    End Sub
    Private Sub standardController_ObjectCreated(ByVal sender As Object, _
         ByVal e As ObjectCreatedEventArgs)
        CType(e.CreatedObject, Task).StartDate = DateTime.Now
    End Sub
End Class
