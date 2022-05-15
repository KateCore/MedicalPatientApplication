<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dtpDateVisited = New System.Windows.Forms.DateTimePicker()
        Me.hdrDate = New System.Windows.Forms.Label()
        Me.hdrFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.hdrSex = New System.Windows.Forms.Label()
        Me.ddlSex = New System.Windows.Forms.ComboBox()
        Me.hdrHeight = New System.Windows.Forms.Label()
        Me.hdrWeight = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.hdrPregnant = New System.Windows.Forms.Label()
        Me.chkPregnant = New System.Windows.Forms.CheckBox()
        Me.gbxBloodType = New System.Windows.Forms.GroupBox()
        Me.radO = New System.Windows.Forms.RadioButton()
        Me.radB = New System.Windows.Forms.RadioButton()
        Me.radAB = New System.Windows.Forms.RadioButton()
        Me.radA = New System.Windows.Forms.RadioButton()
        Me.lstReason = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.hdrReason = New System.Windows.Forms.Label()
        Me.hdrLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.hdrAge = New System.Windows.Forms.Label()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.hdrTemerature = New System.Windows.Forms.Label()
        Me.hdrError1 = New System.Windows.Forms.Label()
        Me.hdrError2 = New System.Windows.Forms.Label()
        Me.hdrError3 = New System.Windows.Forms.Label()
        Me.hdrError4 = New System.Windows.Forms.Label()
        Me.hdrError5 = New System.Windows.Forms.Label()
        Me.hdrError6 = New System.Windows.Forms.Label()
        Me.hdrError7 = New System.Windows.Forms.Label()
        Me.hdrError8 = New System.Windows.Forms.Label()
        Me.hdrError9 = New System.Windows.Forms.Label()
        Me.hdrError10 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.hdrError11 = New System.Windows.Forms.Label()
        Me.gbxBloodType.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpDateVisited
        '
        Me.dtpDateVisited.Enabled = False
        Me.dtpDateVisited.Location = New System.Drawing.Point(88, 28)
        Me.dtpDateVisited.Name = "dtpDateVisited"
        Me.dtpDateVisited.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateVisited.TabIndex = 0
        '
        'hdrDate
        '
        Me.hdrDate.AutoSize = True
        Me.hdrDate.Location = New System.Drawing.Point(12, 32)
        Me.hdrDate.Name = "hdrDate"
        Me.hdrDate.Size = New System.Drawing.Size(70, 13)
        Me.hdrDate.TabIndex = 2
        Me.hdrDate.Text = "Date of Visit: "
        '
        'hdrFirstName
        '
        Me.hdrFirstName.AutoSize = True
        Me.hdrFirstName.Location = New System.Drawing.Point(12, 74)
        Me.hdrFirstName.Name = "hdrFirstName"
        Me.hdrFirstName.Size = New System.Drawing.Size(63, 13)
        Me.hdrFirstName.TabIndex = 3
        Me.hdrFirstName.Text = "First Name: "
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(88, 71)
        Me.txtFirstName.MaxLength = 15
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(200, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'hdrSex
        '
        Me.hdrSex.AutoSize = True
        Me.hdrSex.Location = New System.Drawing.Point(15, 203)
        Me.hdrSex.Name = "hdrSex"
        Me.hdrSex.Size = New System.Drawing.Size(31, 13)
        Me.hdrSex.TabIndex = 5
        Me.hdrSex.Text = "Sex: "
        '
        'ddlSex
        '
        Me.ddlSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlSex.FormattingEnabled = True
        Me.ddlSex.Location = New System.Drawing.Point(91, 199)
        Me.ddlSex.Name = "ddlSex"
        Me.ddlSex.Size = New System.Drawing.Size(122, 21)
        Me.ddlSex.TabIndex = 4
        '
        'hdrHeight
        '
        Me.hdrHeight.AutoSize = True
        Me.hdrHeight.Location = New System.Drawing.Point(15, 246)
        Me.hdrHeight.Name = "hdrHeight"
        Me.hdrHeight.Size = New System.Drawing.Size(44, 13)
        Me.hdrHeight.TabIndex = 7
        Me.hdrHeight.Text = "Height: "
        '
        'hdrWeight
        '
        Me.hdrWeight.AutoSize = True
        Me.hdrWeight.Location = New System.Drawing.Point(15, 289)
        Me.hdrWeight.Name = "hdrWeight"
        Me.hdrWeight.Size = New System.Drawing.Size(47, 13)
        Me.hdrWeight.TabIndex = 8
        Me.hdrWeight.Text = "Weight: "
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(91, 243)
        Me.txtHeight.MaxLength = 4
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(122, 20)
        Me.txtHeight.TabIndex = 5
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(91, 286)
        Me.txtWeight.MaxLength = 4
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(122, 20)
        Me.txtWeight.TabIndex = 6
        '
        'hdrPregnant
        '
        Me.hdrPregnant.AutoSize = True
        Me.hdrPregnant.Location = New System.Drawing.Point(15, 375)
        Me.hdrPregnant.Name = "hdrPregnant"
        Me.hdrPregnant.Size = New System.Drawing.Size(100, 13)
        Me.hdrPregnant.TabIndex = 11
        Me.hdrPregnant.Text = "Check if applicable:"
        '
        'chkPregnant
        '
        Me.chkPregnant.AutoSize = True
        Me.chkPregnant.Location = New System.Drawing.Point(144, 374)
        Me.chkPregnant.Name = "chkPregnant"
        Me.chkPregnant.Size = New System.Drawing.Size(69, 17)
        Me.chkPregnant.TabIndex = 8
        Me.chkPregnant.Text = "Pregnant"
        Me.chkPregnant.UseVisualStyleBackColor = True
        '
        'gbxBloodType
        '
        Me.gbxBloodType.Controls.Add(Me.radO)
        Me.gbxBloodType.Controls.Add(Me.radB)
        Me.gbxBloodType.Controls.Add(Me.radAB)
        Me.gbxBloodType.Controls.Add(Me.radA)
        Me.gbxBloodType.Location = New System.Drawing.Point(431, 219)
        Me.gbxBloodType.Name = "gbxBloodType"
        Me.gbxBloodType.Size = New System.Drawing.Size(231, 100)
        Me.gbxBloodType.TabIndex = 13
        Me.gbxBloodType.TabStop = False
        Me.gbxBloodType.Text = "Blood Type"
        '
        'radO
        '
        Me.radO.AutoSize = True
        Me.radO.Location = New System.Drawing.Point(158, 73)
        Me.radO.Name = "radO"
        Me.radO.Size = New System.Drawing.Size(33, 17)
        Me.radO.TabIndex = 13
        Me.radO.TabStop = True
        Me.radO.Text = "O"
        Me.radO.UseVisualStyleBackColor = True
        '
        'radB
        '
        Me.radB.AutoSize = True
        Me.radB.Location = New System.Drawing.Point(159, 30)
        Me.radB.Name = "radB"
        Me.radB.Size = New System.Drawing.Size(32, 17)
        Me.radB.TabIndex = 11
        Me.radB.TabStop = True
        Me.radB.Text = "B"
        Me.radB.UseVisualStyleBackColor = True
        '
        'radAB
        '
        Me.radAB.AutoSize = True
        Me.radAB.Location = New System.Drawing.Point(35, 73)
        Me.radAB.Name = "radAB"
        Me.radAB.Size = New System.Drawing.Size(39, 17)
        Me.radAB.TabIndex = 12
        Me.radAB.TabStop = True
        Me.radAB.Text = "AB"
        Me.radAB.UseVisualStyleBackColor = True
        '
        'radA
        '
        Me.radA.AutoSize = True
        Me.radA.Location = New System.Drawing.Point(35, 30)
        Me.radA.Name = "radA"
        Me.radA.Size = New System.Drawing.Size(32, 17)
        Me.radA.TabIndex = 10
        Me.radA.TabStop = True
        Me.radA.Text = "A"
        Me.radA.UseVisualStyleBackColor = True
        '
        'lstReason
        '
        Me.lstReason.FormattingEnabled = True
        Me.lstReason.Location = New System.Drawing.Point(431, 48)
        Me.lstReason.Name = "lstReason"
        Me.lstReason.Size = New System.Drawing.Size(231, 134)
        Me.lstReason.TabIndex = 9
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(480, 370)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(587, 370)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "&Add Patient"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'hdrReason
        '
        Me.hdrReason.AutoSize = True
        Me.hdrReason.Location = New System.Drawing.Point(428, 32)
        Me.hdrReason.Name = "hdrReason"
        Me.hdrReason.Size = New System.Drawing.Size(87, 13)
        Me.hdrReason.TabIndex = 17
        Me.hdrReason.Text = "Reason for Visit: "
        '
        'hdrLastName
        '
        Me.hdrLastName.AutoSize = True
        Me.hdrLastName.Location = New System.Drawing.Point(12, 117)
        Me.hdrLastName.Name = "hdrLastName"
        Me.hdrLastName.Size = New System.Drawing.Size(61, 13)
        Me.hdrLastName.TabIndex = 18
        Me.hdrLastName.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(88, 113)
        Me.txtLastName.MaxLength = 15
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(200, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(91, 156)
        Me.txtAge.MaxLength = 3
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(122, 20)
        Me.txtAge.TabIndex = 3
        '
        'hdrAge
        '
        Me.hdrAge.AutoSize = True
        Me.hdrAge.Location = New System.Drawing.Point(15, 160)
        Me.hdrAge.Name = "hdrAge"
        Me.hdrAge.Size = New System.Drawing.Size(29, 13)
        Me.hdrAge.TabIndex = 20
        Me.hdrAge.Text = "Age:"
        '
        'txtTemp
        '
        Me.txtTemp.Location = New System.Drawing.Point(91, 329)
        Me.txtTemp.MaxLength = 4
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(122, 20)
        Me.txtTemp.TabIndex = 7
        '
        'hdrTemerature
        '
        Me.hdrTemerature.AutoSize = True
        Me.hdrTemerature.Location = New System.Drawing.Point(15, 332)
        Me.hdrTemerature.Name = "hdrTemerature"
        Me.hdrTemerature.Size = New System.Drawing.Size(73, 13)
        Me.hdrTemerature.TabIndex = 22
        Me.hdrTemerature.Text = "Temperature: "
        '
        'hdrError1
        '
        Me.hdrError1.AutoSize = True
        Me.hdrError1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrError1.ForeColor = System.Drawing.Color.Red
        Me.hdrError1.Location = New System.Drawing.Point(287, 30)
        Me.hdrError1.Name = "hdrError1"
        Me.hdrError1.Size = New System.Drawing.Size(16, 20)
        Me.hdrError1.TabIndex = 23
        Me.hdrError1.Text = "*"
        Me.hdrError1.Visible = False
        '
        'hdrError2
        '
        Me.hdrError2.AutoSize = True
        Me.hdrError2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrError2.ForeColor = System.Drawing.Color.Red
        Me.hdrError2.Location = New System.Drawing.Point(287, 73)
        Me.hdrError2.Name = "hdrError2"
        Me.hdrError2.Size = New System.Drawing.Size(16, 20)
        Me.hdrError2.TabIndex = 24
        Me.hdrError2.Text = "*"
        Me.hdrError2.Visible = False
        '
        'hdrError3
        '
        Me.hdrError3.AutoSize = True
        Me.hdrError3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrError3.ForeColor = System.Drawing.Color.Red
        Me.hdrError3.Location = New System.Drawing.Point(287, 116)
        Me.hdrError3.Name = "hdrError3"
        Me.hdrError3.Size = New System.Drawing.Size(16, 20)
        Me.hdrError3.TabIndex = 25
        Me.hdrError3.Text = "*"
        Me.hdrError3.Visible = False
        '
        'hdrError4
        '
        Me.hdrError4.AutoSize = True
        Me.hdrError4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrError4.ForeColor = System.Drawing.Color.Red
        Me.hdrError4.Location = New System.Drawing.Point(212, 158)
        Me.hdrError4.Name = "hdrError4"
        Me.hdrError4.Size = New System.Drawing.Size(16, 20)
        Me.hdrError4.TabIndex = 26
        Me.hdrError4.Text = "*"
        Me.hdrError4.Visible = False
        '
        'hdrError5
        '
        Me.hdrError5.AutoSize = True
        Me.hdrError5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrError5.ForeColor = System.Drawing.Color.Red
        Me.hdrError5.Location = New System.Drawing.Point(211, 202)
        Me.hdrError5.Name = "hdrError5"
        Me.hdrError5.Size = New System.Drawing.Size(16, 20)
        Me.hdrError5.TabIndex = 27
        Me.hdrError5.Text = "*"
        Me.hdrError5.Visible = False
        '
        'hdrError6
        '
        Me.hdrError6.AutoSize = True
        Me.hdrError6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrError6.ForeColor = System.Drawing.Color.Red
        Me.hdrError6.Location = New System.Drawing.Point(212, 246)
        Me.hdrError6.Name = "hdrError6"
        Me.hdrError6.Size = New System.Drawing.Size(16, 20)
        Me.hdrError6.TabIndex = 28
        Me.hdrError6.Text = "*"
        Me.hdrError6.Visible = False
        '
        'hdrError7
        '
        Me.hdrError7.AutoSize = True
        Me.hdrError7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrError7.ForeColor = System.Drawing.Color.Red
        Me.hdrError7.Location = New System.Drawing.Point(212, 288)
        Me.hdrError7.Name = "hdrError7"
        Me.hdrError7.Size = New System.Drawing.Size(16, 20)
        Me.hdrError7.TabIndex = 29
        Me.hdrError7.Text = "*"
        Me.hdrError7.Visible = False
        '
        'hdrError8
        '
        Me.hdrError8.AutoSize = True
        Me.hdrError8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrError8.ForeColor = System.Drawing.Color.Red
        Me.hdrError8.Location = New System.Drawing.Point(212, 332)
        Me.hdrError8.Name = "hdrError8"
        Me.hdrError8.Size = New System.Drawing.Size(16, 20)
        Me.hdrError8.TabIndex = 30
        Me.hdrError8.Text = "*"
        Me.hdrError8.Visible = False
        '
        'hdrError9
        '
        Me.hdrError9.AutoSize = True
        Me.hdrError9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrError9.ForeColor = System.Drawing.Color.Red
        Me.hdrError9.Location = New System.Drawing.Point(661, 48)
        Me.hdrError9.Name = "hdrError9"
        Me.hdrError9.Size = New System.Drawing.Size(16, 20)
        Me.hdrError9.TabIndex = 31
        Me.hdrError9.Text = "*"
        Me.hdrError9.Visible = False
        '
        'hdrError10
        '
        Me.hdrError10.AutoSize = True
        Me.hdrError10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrError10.ForeColor = System.Drawing.Color.Red
        Me.hdrError10.Location = New System.Drawing.Point(661, 226)
        Me.hdrError10.Name = "hdrError10"
        Me.hdrError10.Size = New System.Drawing.Size(16, 20)
        Me.hdrError10.TabIndex = 32
        Me.hdrError10.Text = "*"
        Me.hdrError10.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(363, 370)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'hdrError11
        '
        Me.hdrError11.AutoSize = True
        Me.hdrError11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdrError11.ForeColor = System.Drawing.Color.Red
        Me.hdrError11.Location = New System.Drawing.Point(210, 376)
        Me.hdrError11.Name = "hdrError11"
        Me.hdrError11.Size = New System.Drawing.Size(16, 20)
        Me.hdrError11.TabIndex = 34
        Me.hdrError11.Text = "*"
        Me.hdrError11.Visible = False
        '
        'frmPatient
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 410)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.hdrTemerature)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.hdrAge)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.hdrLastName)
        Me.Controls.Add(Me.hdrReason)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstReason)
        Me.Controls.Add(Me.gbxBloodType)
        Me.Controls.Add(Me.hdrPregnant)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.hdrWeight)
        Me.Controls.Add(Me.hdrHeight)
        Me.Controls.Add(Me.ddlSex)
        Me.Controls.Add(Me.hdrSex)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.hdrFirstName)
        Me.Controls.Add(Me.hdrDate)
        Me.Controls.Add(Me.dtpDateVisited)
        Me.Controls.Add(Me.hdrError1)
        Me.Controls.Add(Me.hdrError2)
        Me.Controls.Add(Me.hdrError3)
        Me.Controls.Add(Me.hdrError4)
        Me.Controls.Add(Me.hdrError5)
        Me.Controls.Add(Me.hdrError6)
        Me.Controls.Add(Me.hdrError7)
        Me.Controls.Add(Me.hdrError8)
        Me.Controls.Add(Me.hdrError9)
        Me.Controls.Add(Me.hdrError10)
        Me.Controls.Add(Me.hdrError11)
        Me.Controls.Add(Me.chkPregnant)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPatient"
        Me.Text = "Patient (Katelyn Correa #76)"
        Me.gbxBloodType.ResumeLayout(False)
        Me.gbxBloodType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDateVisited As DateTimePicker
    Friend WithEvents hdrDate As Label
    Friend WithEvents hdrFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents hdrSex As Label
    Friend WithEvents ddlSex As ComboBox
    Friend WithEvents hdrHeight As Label
    Friend WithEvents hdrWeight As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents hdrPregnant As Label
    Friend WithEvents chkPregnant As CheckBox
    Friend WithEvents gbxBloodType As GroupBox
    Friend WithEvents radO As RadioButton
    Friend WithEvents radB As RadioButton
    Friend WithEvents radAB As RadioButton
    Friend WithEvents radA As RadioButton
    Friend WithEvents lstReason As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents hdrReason As Label
    Friend WithEvents hdrLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents hdrAge As Label
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents hdrTemerature As Label
    Friend WithEvents hdrError1 As Label
    Friend WithEvents hdrError2 As Label
    Friend WithEvents hdrError3 As Label
    Friend WithEvents hdrError4 As Label
    Friend WithEvents hdrError5 As Label
    Friend WithEvents hdrError6 As Label
    Friend WithEvents hdrError7 As Label
    Friend WithEvents hdrError8 As Label
    Friend WithEvents hdrError9 As Label
    Friend WithEvents hdrError10 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents hdrError11 As Label
End Class
