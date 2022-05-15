<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lstRecords = New System.Windows.Forms.ListBox()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.hdrTemerature = New System.Windows.Forms.Label()
        Me.hdrAge = New System.Windows.Forms.Label()
        Me.hdrLastName = New System.Windows.Forms.Label()
        Me.hdrWeight = New System.Windows.Forms.Label()
        Me.hdrHeight = New System.Windows.Forms.Label()
        Me.hdrSex = New System.Windows.Forms.Label()
        Me.hdrFirstName = New System.Windows.Forms.Label()
        Me.hdrDate = New System.Windows.Forms.Label()
        Me.gbxPatientDetails = New System.Windows.Forms.GroupBox()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblDateOfVisit = New System.Windows.Forms.Label()
        Me.hdrReason4Visit = New System.Windows.Forms.Label()
        Me.hdrBloodType = New System.Windows.Forms.Label()
        Me.hdrPregnant = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.lblPregnant = New System.Windows.Forms.Label()
        Me.lblBloodType = New System.Windows.Forms.Label()
        Me.lblReason = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbxPatientDetails.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstRecords
        '
        Me.lstRecords.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRecords.FormattingEnabled = True
        Me.lstRecords.ItemHeight = 15
        Me.lstRecords.Location = New System.Drawing.Point(12, 36)
        Me.lstRecords.Name = "lstRecords"
        Me.lstRecords.Size = New System.Drawing.Size(398, 394)
        Me.lstRecords.TabIndex = 0
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(214, 451)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNew.TabIndex = 1
        Me.btnAddNew.Text = "&New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(335, 451)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(456, 451)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'hdrTemerature
        '
        Me.hdrTemerature.AutoSize = True
        Me.hdrTemerature.Location = New System.Drawing.Point(25, 264)
        Me.hdrTemerature.Name = "hdrTemerature"
        Me.hdrTemerature.Size = New System.Drawing.Size(73, 13)
        Me.hdrTemerature.TabIndex = 30
        Me.hdrTemerature.Text = "Temperature: "
        '
        'hdrAge
        '
        Me.hdrAge.AutoSize = True
        Me.hdrAge.Location = New System.Drawing.Point(25, 128)
        Me.hdrAge.Name = "hdrAge"
        Me.hdrAge.Size = New System.Drawing.Size(29, 13)
        Me.hdrAge.TabIndex = 29
        Me.hdrAge.Text = "Age:"
        '
        'hdrLastName
        '
        Me.hdrLastName.AutoSize = True
        Me.hdrLastName.Location = New System.Drawing.Point(25, 94)
        Me.hdrLastName.Name = "hdrLastName"
        Me.hdrLastName.Size = New System.Drawing.Size(61, 13)
        Me.hdrLastName.TabIndex = 28
        Me.hdrLastName.Text = "Last Name:"
        '
        'hdrWeight
        '
        Me.hdrWeight.AutoSize = True
        Me.hdrWeight.Location = New System.Drawing.Point(25, 230)
        Me.hdrWeight.Name = "hdrWeight"
        Me.hdrWeight.Size = New System.Drawing.Size(47, 13)
        Me.hdrWeight.TabIndex = 27
        Me.hdrWeight.Text = "Weight: "
        '
        'hdrHeight
        '
        Me.hdrHeight.AutoSize = True
        Me.hdrHeight.Location = New System.Drawing.Point(25, 196)
        Me.hdrHeight.Name = "hdrHeight"
        Me.hdrHeight.Size = New System.Drawing.Size(44, 13)
        Me.hdrHeight.TabIndex = 26
        Me.hdrHeight.Text = "Height: "
        '
        'hdrSex
        '
        Me.hdrSex.AutoSize = True
        Me.hdrSex.Location = New System.Drawing.Point(25, 162)
        Me.hdrSex.Name = "hdrSex"
        Me.hdrSex.Size = New System.Drawing.Size(31, 13)
        Me.hdrSex.TabIndex = 25
        Me.hdrSex.Text = "Sex: "
        '
        'hdrFirstName
        '
        Me.hdrFirstName.AutoSize = True
        Me.hdrFirstName.Location = New System.Drawing.Point(25, 60)
        Me.hdrFirstName.Name = "hdrFirstName"
        Me.hdrFirstName.Size = New System.Drawing.Size(63, 13)
        Me.hdrFirstName.TabIndex = 24
        Me.hdrFirstName.Text = "First Name: "
        '
        'hdrDate
        '
        Me.hdrDate.AutoSize = True
        Me.hdrDate.Location = New System.Drawing.Point(25, 26)
        Me.hdrDate.Name = "hdrDate"
        Me.hdrDate.Size = New System.Drawing.Size(70, 13)
        Me.hdrDate.TabIndex = 23
        Me.hdrDate.Text = "Date of Visit: "
        '
        'gbxPatientDetails
        '
        Me.gbxPatientDetails.Controls.Add(Me.lblReason)
        Me.gbxPatientDetails.Controls.Add(Me.lblBloodType)
        Me.gbxPatientDetails.Controls.Add(Me.lblPregnant)
        Me.gbxPatientDetails.Controls.Add(Me.lblTemp)
        Me.gbxPatientDetails.Controls.Add(Me.lblWeight)
        Me.gbxPatientDetails.Controls.Add(Me.lblHeight)
        Me.gbxPatientDetails.Controls.Add(Me.lblSex)
        Me.gbxPatientDetails.Controls.Add(Me.lblAge)
        Me.gbxPatientDetails.Controls.Add(Me.lblLastName)
        Me.gbxPatientDetails.Controls.Add(Me.lblFirstName)
        Me.gbxPatientDetails.Controls.Add(Me.lblDateOfVisit)
        Me.gbxPatientDetails.Controls.Add(Me.hdrReason4Visit)
        Me.gbxPatientDetails.Controls.Add(Me.hdrBloodType)
        Me.gbxPatientDetails.Controls.Add(Me.hdrPregnant)
        Me.gbxPatientDetails.Controls.Add(Me.hdrFirstName)
        Me.gbxPatientDetails.Controls.Add(Me.hdrTemerature)
        Me.gbxPatientDetails.Controls.Add(Me.hdrDate)
        Me.gbxPatientDetails.Controls.Add(Me.hdrAge)
        Me.gbxPatientDetails.Controls.Add(Me.hdrSex)
        Me.gbxPatientDetails.Controls.Add(Me.hdrLastName)
        Me.gbxPatientDetails.Controls.Add(Me.hdrHeight)
        Me.gbxPatientDetails.Controls.Add(Me.hdrWeight)
        Me.gbxPatientDetails.Location = New System.Drawing.Point(433, 36)
        Me.gbxPatientDetails.Name = "gbxPatientDetails"
        Me.gbxPatientDetails.Size = New System.Drawing.Size(298, 394)
        Me.gbxPatientDetails.TabIndex = 31
        Me.gbxPatientDetails.TabStop = False
        Me.gbxPatientDetails.Text = "Patient Record"
        Me.gbxPatientDetails.Visible = False
        '
        'lblSex
        '
        Me.lblSex.Location = New System.Drawing.Point(132, 162)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(138, 13)
        Me.lblSex.TabIndex = 38
        Me.lblSex.Text = "SEX"
        '
        'lblAge
        '
        Me.lblAge.Location = New System.Drawing.Point(132, 128)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(138, 13)
        Me.lblAge.TabIndex = 37
        Me.lblAge.Text = "AGE"
        '
        'lblLastName
        '
        Me.lblLastName.Location = New System.Drawing.Point(132, 94)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(138, 13)
        Me.lblLastName.TabIndex = 36
        Me.lblLastName.Text = "LAST NAME"
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(132, 60)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(138, 13)
        Me.lblFirstName.TabIndex = 35
        Me.lblFirstName.Text = "FIRST NAME"
        '
        'lblDateOfVisit
        '
        Me.lblDateOfVisit.Location = New System.Drawing.Point(132, 26)
        Me.lblDateOfVisit.Name = "lblDateOfVisit"
        Me.lblDateOfVisit.Size = New System.Drawing.Size(138, 13)
        Me.lblDateOfVisit.TabIndex = 34
        Me.lblDateOfVisit.Text = "DATE"
        '
        'hdrReason4Visit
        '
        Me.hdrReason4Visit.AutoSize = True
        Me.hdrReason4Visit.Location = New System.Drawing.Point(25, 366)
        Me.hdrReason4Visit.Name = "hdrReason4Visit"
        Me.hdrReason4Visit.Size = New System.Drawing.Size(84, 13)
        Me.hdrReason4Visit.TabIndex = 33
        Me.hdrReason4Visit.Text = "Reason for Visit:"
        '
        'hdrBloodType
        '
        Me.hdrBloodType.AutoSize = True
        Me.hdrBloodType.Location = New System.Drawing.Point(25, 332)
        Me.hdrBloodType.Name = "hdrBloodType"
        Me.hdrBloodType.Size = New System.Drawing.Size(64, 13)
        Me.hdrBloodType.TabIndex = 32
        Me.hdrBloodType.Text = "Blood Type:"
        '
        'hdrPregnant
        '
        Me.hdrPregnant.AutoSize = True
        Me.hdrPregnant.Location = New System.Drawing.Point(25, 298)
        Me.hdrPregnant.Name = "hdrPregnant"
        Me.hdrPregnant.Size = New System.Drawing.Size(53, 13)
        Me.hdrPregnant.TabIndex = 31
        Me.hdrPregnant.Text = "Pregnant:"
        '
        'lblHeight
        '
        Me.lblHeight.Location = New System.Drawing.Point(132, 196)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(138, 13)
        Me.lblHeight.TabIndex = 39
        Me.lblHeight.Text = "HEIGHT"
        '
        'lblWeight
        '
        Me.lblWeight.Location = New System.Drawing.Point(132, 230)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(138, 13)
        Me.lblWeight.TabIndex = 40
        Me.lblWeight.Text = "WEIGHT"
        '
        'lblTemp
        '
        Me.lblTemp.Location = New System.Drawing.Point(132, 264)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(138, 13)
        Me.lblTemp.TabIndex = 41
        Me.lblTemp.Text = "TEMPERATURE"
        '
        'lblPregnant
        '
        Me.lblPregnant.Location = New System.Drawing.Point(132, 298)
        Me.lblPregnant.Name = "lblPregnant"
        Me.lblPregnant.Size = New System.Drawing.Size(138, 13)
        Me.lblPregnant.TabIndex = 42
        Me.lblPregnant.Text = "PREGNANT"
        '
        'lblBloodType
        '
        Me.lblBloodType.Location = New System.Drawing.Point(132, 332)
        Me.lblBloodType.Name = "lblBloodType"
        Me.lblBloodType.Size = New System.Drawing.Size(138, 13)
        Me.lblBloodType.TabIndex = 43
        Me.lblBloodType.Text = "BLOOD TYPE"
        '
        'lblReason
        '
        Me.lblReason.Location = New System.Drawing.Point(132, 366)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(138, 13)
        Me.lblReason.TabIndex = 44
        Me.lblReason.Text = "REASON"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(754, 24)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 490)
        Me.Controls.Add(Me.gbxPatientDetails)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.lstRecords)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = " Patient Records (Katelyn Correa #76)"
        Me.gbxPatientDetails.ResumeLayout(False)
        Me.gbxPatientDetails.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstRecords As ListBox
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents hdrTemerature As Label
    Friend WithEvents hdrAge As Label
    Friend WithEvents hdrLastName As Label
    Friend WithEvents hdrWeight As Label
    Friend WithEvents hdrHeight As Label
    Friend WithEvents hdrSex As Label
    Friend WithEvents hdrFirstName As Label
    Friend WithEvents hdrDate As Label
    Friend WithEvents gbxPatientDetails As GroupBox
    Friend WithEvents lblSex As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblDateOfVisit As Label
    Friend WithEvents hdrReason4Visit As Label
    Friend WithEvents hdrBloodType As Label
    Friend WithEvents hdrPregnant As Label
    Friend WithEvents lblReason As Label
    Friend WithEvents lblBloodType As Label
    Friend WithEvents lblPregnant As Label
    Friend WithEvents lblTemp As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
