Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace AgendViewComponent
	Partial Public Class GoToDateDialog
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub GoToDateDialog_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub

		Public Property SelectedDate() As DateTime
			Get
				Return dateEditGoToDate.DateTime
			End Get
			Set(ByVal value As DateTime)
				dateEditGoToDate.EditValue = value
			End Set
		End Property
	End Class
End Namespace
