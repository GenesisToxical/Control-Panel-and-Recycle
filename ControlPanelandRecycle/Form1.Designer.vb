<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Rem_R = New System.Windows.Forms.PictureBox()
        Me.Add_R = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rem_P = New System.Windows.Forms.PictureBox()
        Me.Add_P = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Rem_R, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Add_R, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Rem_P, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Add_P, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        resources.ApplyResources(Me.LinkLabel1, "LinkLabel1")
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.TabStop = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Name = "Label2"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Rem_R)
        Me.GroupBox2.Controls.Add(Me.Add_R)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'Rem_R
        '
        Me.Rem_R.BackgroundImage = Global.ControlPanelandRecycle.My.Resources.Resources.Remove1
        resources.ApplyResources(Me.Rem_R, "Rem_R")
        Me.Rem_R.Name = "Rem_R"
        Me.Rem_R.TabStop = False
        '
        'Add_R
        '
        Me.Add_R.BackgroundImage = Global.ControlPanelandRecycle.My.Resources.Resources.Add1
        resources.ApplyResources(Me.Add_R, "Add_R")
        Me.Add_R.Name = "Add_R"
        Me.Add_R.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Name = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Rem_P)
        Me.GroupBox1.Controls.Add(Me.Add_P)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Rem_P
        '
        Me.Rem_P.BackgroundImage = Global.ControlPanelandRecycle.My.Resources.Resources.Remove1
        resources.ApplyResources(Me.Rem_P, "Rem_P")
        Me.Rem_P.Name = "Rem_P"
        Me.Rem_P.TabStop = False
        '
        'Add_P
        '
        Me.Add_P.BackgroundImage = Global.ControlPanelandRecycle.My.Resources.Resources.Add1
        resources.ApplyResources(Me.Add_P, "Add_P")
        Me.Add_P.Name = "Add_P"
        Me.Add_P.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.ControlPanelandRecycle.My.Resources.Resources.heart
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ControlPanelandRecycle.My.Resources.Resources.Background
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.TopMost = True
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Rem_R, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Add_R, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Rem_P, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Add_P, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Add_P As PictureBox
    Friend WithEvents Rem_R As PictureBox
    Friend WithEvents Add_R As PictureBox
    Friend WithEvents Rem_P As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
