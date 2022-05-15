<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtAbout = New System.Windows.Forms.RichTextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 230)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtAbout
        '
        Me.txtAbout.BackColor = System.Drawing.SystemColors.Menu
        Me.txtAbout.Location = New System.Drawing.Point(303, 28)
        Me.txtAbout.Name = "txtAbout"
        Me.txtAbout.ReadOnly = True
        Me.txtAbout.Size = New System.Drawing.Size(241, 147)
        Me.txtAbout.TabIndex = 1
        Me.txtAbout.Text = "This application is designed to display details of patient records, allow new pat" &
    "ients, and update old records." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "By Katelyn Correa" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(303, 235)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(433, 235)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit Application"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAbout
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 270)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtAbout)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAbout"
        Me.Text = "About"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtAbout As RichTextBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnExit As Button
End Class
