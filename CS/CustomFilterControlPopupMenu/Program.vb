Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Skins
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports System.Collections.Generic

Namespace CustomFilterControlPopupMenu
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			SkinManager.EnableFormSkins()
			UserLookAndFeel.Default.SkinName = "Money Twins"
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace