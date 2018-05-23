Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.SystemModule
Imports DevExpress.Persistent.BaseImpl

Namespace HowToInitializeObjectCreatedViaNewAction.Module
	Partial Public Class MyController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
		End Sub

		Private Sub MyController_FrameAssigned(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.FrameAssigned
			Dim standardController As NewObjectViewController = Frame.GetController(Of NewObjectViewController)()
			AddHandler standardController.ObjectCreated, AddressOf standardController_ObjectCreated
		End Sub

		Private Sub standardController_ObjectCreated(ByVal sender As Object, ByVal e As ObjectCreatedEventArgs)
			If TypeOf e.CreatedObject Is Task Then
				CType(e.CreatedObject, Task).StartDate = DateTime.Now
			End If
		End Sub


	End Class
End Namespace
