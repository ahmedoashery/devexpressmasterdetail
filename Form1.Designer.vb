Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.gridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(548, 153)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsDetail.EnableMasterViewMode = False
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' gridControl2
			' 
			Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.gridControl2.Location = New System.Drawing.Point(0, 524)
			Me.gridControl2.MainView = Me.gridView3
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.ShowOnlyPredefinedDetails = True
			Me.gridControl2.Size = New System.Drawing.Size(548, 162)
			Me.gridControl2.TabIndex = 1
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView3, Me.gridView4})
			' 
			' gridView3
			' 
			Me.gridView3.GridControl = Me.gridControl2
			Me.gridView3.Name = "gridView3"
			' 
			' gridView4
			' 
			Me.gridView4.GridControl = Me.gridControl2
			Me.gridView4.Name = "gridView4"
			' 
			' dataLayoutControl1
			' 
			Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 177)
			Me.dataLayoutControl1.Name = "dataLayoutControl1"
			Me.dataLayoutControl1.Root = Me.layoutControlGroup1
			Me.dataLayoutControl1.Size = New System.Drawing.Size(548, 347)
			Me.dataLayoutControl1.TabIndex = 2
			Me.dataLayoutControl1.Text = "dataLayoutControl1"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(548, 347)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' dataNavigator1
			' 
			Me.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Top
			Me.dataNavigator1.Location = New System.Drawing.Point(0, 153)
			Me.dataNavigator1.Name = "dataNavigator1"
			Me.dataNavigator1.Size = New System.Drawing.Size(548, 24)
			Me.dataNavigator1.TabIndex = 3
			Me.dataNavigator1.Text = "dataNavigator1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(548, 686)
			Me.Controls.Add(Me.dataLayoutControl1)
			Me.Controls.Add(Me.gridControl2)
			Me.Controls.Add(Me.dataNavigator1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private gridView3 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView4 As DevExpress.XtraGrid.Views.Grid.GridView
		Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
	End Class
End Namespace

