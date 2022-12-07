Imports Microsoft.VisualBasic
Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub ASPxComboBox1_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim cmb As ASPxComboBox = TryCast(sender, ASPxComboBox)
		Dim sqlDs As SqlDataSource = TryCast(FindControl(ASPxComboBox1.DataSourceID), SqlDataSource)
		If sqlDs Is Nothing Then
			Return
		End If

		Dim dv As DataView = CType(sqlDs.Select(DataSourceSelectArguments.Empty), DataView)

		For Each dc As DataColumn In dv.Table.Columns
			cmb.Columns.Add(dc.ColumnName, SplitPascalCaseString(dc.ColumnName))
		Next dc
	End Sub

	Private Function SplitPascalCaseString(ByVal value As String) As String
		value = Regex.Replace(value, "(\p{Ll})(\p{Lu})", "$1 $2")
		value = Regex.Replace(value, "(\p{Lu}{2})(\p{Lu}\p{Ll}{2})", "$1 $2")
		Return value
	End Function
End Class