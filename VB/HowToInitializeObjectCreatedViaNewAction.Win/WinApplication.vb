Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Win
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp

Namespace HowToInitializeObjectCreatedViaNewAction.Win
    Partial Public Class HowToInitializeObjectCreatedViaNewActionWindowsFormsApplication
        Inherits WinApplication
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub HowToInitializeObjectCreatedViaNewActionWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
            e.Updater.Update()
            e.Handled = True
        End Sub
    End Class
End Namespace
