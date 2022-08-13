Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private i As Integer
		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable("Parent")
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			tbl.Columns.Add("DETAILID", GetType(Integer))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i), i })
			Next i
			Return tbl
		End Function

		Private detTbl As DataTable
		Private Function CreateDet1Table(ByVal RowCount As Integer) As DataTable
			detTbl = New DataTable("Det1")
			detTbl.Columns.Add("Name", GetType(String))
			detTbl.Columns.Add("ID", GetType(Integer))
			For j As Integer = 0 To RowCount - 1
				For i As Integer = 0 To RowCount - 1
					detTbl.Rows.Add(New Object() { String.Format("Detail1Name{0}", i), i })
				Next i
			Next j
			Return detTbl
		End Function



		Private Function GetMasterDetail() As DataSet
			Dim ds As New DataSet("TestDS")
			ds.Tables.Add(CreateTable(20))
			ds.Tables.Add(CreateDet1Table(20))
			Dim parentColumn As DataColumn = ds.Tables("Parent").Columns("DETAILID")
			Dim childColumn As DataColumn = ds.Tables("Det1").Columns("ID")
			ds.Relations.Add(New DataRelation("relDet1", parentColumn, childColumn))
			Return ds
		End Function


		Public Sub New()
			InitializeComponent()
			Dim ds As DataSet = GetMasterDetail()
			gridControl1.DataSource = ds.Tables("Parent")

			gridControl2.DataSource = ds.Tables("Parent")
			gridControl2.DataMember = "relDet1"

			dataLayoutControl1.DataSource = ds.Tables("Parent")
			dataLayoutControl1.RetrieveFields()

			dataNavigator1.DataSource = ds.Tables("Parent")

		End Sub
	End Class
End Namespace