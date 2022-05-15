'******************************************************
'* Name:       Katelyn Correa
'* Class:      CIS-1510
'* Assignment: Project Fall 2020
'* File:       frmPatient.vb
'* Purpose:    get patient info and add to records
'******************************************************

Option Strict On
Option Explicit On
Option Infer Off
Option Compare Binary

Imports System.IO
Imports System.Text


Public Class frmPatient
    Private Const FILENAME As String = "sex.txt"
    Private Const FILENAME2 As String = "reasons.txt"
    Private Const MAINFILE As String = "patientData.txt"

    Public numPatients As Integer = 0
    Dim thePatient As Patient
    Dim newPatient As Boolean

    Public Sub New(pPatient As Patient, pNewPatientFlag As Boolean)
        thePatient = pPatient
        newPatient = pNewPatientFlag
        InitializeComponent()
    End Sub
    Private Sub frmPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSex()
        loadReasons()


        If thePatient.firstName = "" Then
            txtFirstName.Select()
            btnAdd.Text = "&Add Patient"
        Else
            dtpDateVisited.Value = thePatient.dateVisited
            txtFirstName.Text = thePatient.firstName
            txtLastName.Text = thePatient.lastName
            txtAge.Text = thePatient.age.ToString()
            txtHeight.Text = thePatient.height.ToString()
            txtWeight.Text = thePatient.weight.ToString()
            txtTemp.Text = thePatient.temperature.ToString()

            If thePatient.pregnant = True Then
                chkPregnant.Checked = True
            Else
                chkPregnant.Checked = False
            End If
            'get lstReason
            Dim index As Integer = 0
            Dim max As Integer
            max = lstReason.Items.Count

            For index = 0 To max - 1
                If lstReason.Items(index).ToString() = thePatient.reason Then
                    lstReason.SelectedIndex = index
                End If
            Next

            'get blood type
            If thePatient.bloodType = "A" Then
                radA.Checked = True
            ElseIf thePatient.bloodType = "B" Then
                radB.Checked = True
            ElseIf thePatient.bloodType = "AB" Then
                radAB.Checked = True
            ElseIf thePatient.bloodType = "O" Then
                radO.Checked = True
            End If

            'get sex
            max = ddlSex.Items.Count
            For index = 0 To max - 1
                If ddlSex.Items(index).ToString() = thePatient.sex Then
                    ddlSex.SelectedIndex = index
                End If
            Next

            'rename add btn
            btnAdd.Text = "&Save"

        End If


    End Sub
    'BUTTONES
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        hdrError1.Visible = False
        hdrError2.Visible = False
        hdrError3.Visible = False
        hdrError4.Visible = False
        hdrError5.Visible = False
        hdrError6.Visible = False
        hdrError7.Visible = False
        hdrError8.Visible = False
        hdrError9.Visible = False
        hdrError10.Visible = False
        hdrError11.Visible = False




        'check to see if record is being updated or a new record and that either way the form is completed properly
        If btnAdd.Text = "&Add Patient" AndAlso checkCompletetion() Then
            writeToFile()
            Me.Close()
        ElseIf btnAdd.Text = "&Save" AndAlso checkCompletetion() Then
            updateFile(thePatient.patientID)
            Me.Close()
        End If




    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dtpDateVisited.Value = Date.Today()
        txtFirstName.Text = ""
        txtLastName.Text = ""
        ddlSex.SelectedIndex = -1
        txtAge.Text = ""
        txtHeight.Text = ""
        txtWeight.Text = ""
        txtTemp.Text = ""
        chkPregnant.Checked = False
        lstReason.SelectedIndex = -1
        radA.Checked = False
        radAB.Checked = False
        radB.Checked = False
        radO.Checked = False
        txtFirstName.Select()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    'additional methods
    Private Function checkCompletetion() As Boolean
        'do not return false if pregnant box is unchecked 
        If txtFirstName.Text = "" Then
            hdrError2.Visible = True
            txtFirstName.Select()
            MsgBox("You must fill in all portions of the form!", MsgBoxStyle.Critical, "Error!")
            Return False
        ElseIf txtLastName.Text = "" Then
            hdrError3.Visible = True
            txtLastName.Select()
            MsgBox("You must fill in all portions of the form!", MsgBoxStyle.Critical, "Error!")
            Return False
        ElseIf txtAge.Text = "" Then
            hdrError4.Visible = True
            txtAge.Select()
            MsgBox("You must fill in all portions of the form!", MsgBoxStyle.Critical, "Error!")
            Return False
        ElseIf Convert.ToInt32(txtAge.Text) < 0 OrElse Convert.ToInt32(txtAge.Text) > 130 Then
            hdrError4.Visible = True
            txtAge.Select()
            MsgBox("Age must be between 0 and 130", MsgBoxStyle.Critical, "Error!")
            Return False
        ElseIf ddlSex.SelectedIndex = -1 Then
            hdrError5.Visible = True
            ddlSex.Select()
            MsgBox("You must fill in all portions of the form!", MsgBoxStyle.Critical, "Error!")
            Return False
        ElseIf txtHeight.Text = "" Then
            hdrError6.Visible = True
            txtHeight.Select()
            MsgBox("You must fill in all portions of the form!", MsgBoxStyle.Critical, "Error!")
            Return False
        ElseIf Convert.ToDecimal(txtHeight.Text) < 0 OrElse Convert.ToDecimal(txtHeight.Text) > 10 Then
            hdrError6.Visible = True
            txtHeight.Select()
            MsgBox("Height must be between 0 and 10", MsgBoxStyle.Critical, "Error!")
            Return False
        ElseIf txtWeight.Text = "" Then
            hdrError7.Visible = True
            txtWeight.Select()
            MsgBox("You must fill in all portions of the form!", MsgBoxStyle.Critical, "Error!")
            Return False
        ElseIf Convert.ToDecimal(txtWeight.Text) <= 0 OrElse Convert.ToDecimal(txtWeight.Text) > 1400 Then
            hdrError7.Visible = True
            txtWeight.Select()
            MsgBox("Weight must be greater than zero and less than 1400!", MsgBoxStyle.Critical, "Error!")
            Return False
        ElseIf txtTemp.Text = "" Then
            hdrError8.Visible = True
            txtTemp.Select()
            MsgBox("You must fill in all portions of the form!", MsgBoxStyle.Critical, "Error!")
            Return False
        ElseIf Convert.ToDecimal(txtTemp.Text) < 90 OrElse Convert.ToDecimal(txtTemp.Text) > 120 Then
            hdrError8.Visible = True
            txtTemp.Select()
            MsgBox("Temperature must be between 90 and 120", MsgBoxStyle.Critical, "Error!")
        ElseIf lstReason.SelectedIndex = -1 Then
            hdrError9.Visible = True
            lstReason.Select()
            MsgBox("You must fill in all portions of the form!", MsgBoxStyle.Critical, "Error!")
            Return False
        ElseIf radA.Checked = False AndAlso radAB.Checked = False AndAlso radB.Checked = False AndAlso radO.Checked = False Then
            hdrError10.Visible = True
            gbxBloodType.Select()
            MsgBox("You must fill in all portions of the form!", MsgBoxStyle.Critical, "Error!")
            Return False
        ElseIf ddlSex.SelectedItem.ToString() = "Male" AndAlso chkPregnant.Checked = True Then
            hdrError11.Visible = True
            hdrError5.Visible = True
            chkPregnant.Select()
            MsgBox("If the sex is Male, then status of pregnant must be unchecked.", MsgBoxStyle.Critical, "Error!")
            Return False
        Else
            Return True
        End If
    End Function

    'FUNCTIONS TO LOAD FILES
    Private Sub loadSex()
        Dim inFile As IO.StreamReader
        Dim line As String

        If IO.File.Exists(FILENAME) Then
            'MsgBox("File found")
            inFile = File.OpenText(FILENAME)

            Do Until inFile.Peek = -1
                line = inFile.ReadLine
                'MsgBox(line)
                ddlSex.Items.Add(line)

            Loop
            inFile.Close()
        Else
            MsgBox("Problem loading the sex.txt")

        End If
    End Sub
    Private Sub loadReasons()
        Dim inFile As IO.StreamReader
        Dim line As String

        If IO.File.Exists(FILENAME2) Then
            'MsgBox("File found")
            inFile = File.OpenText(FILENAME2)

            Do Until inFile.Peek = -1
                line = inFile.ReadLine
                'MsgBox(line)
                lstReason.Items.Add(line)

            Loop
            inFile.Close()
        Else
            MsgBox("Problem loading the reasons.txt")

        End If
    End Sub

    Private Sub writeToFile()
        Dim outFile As IO.StreamWriter
        Dim bloodType As String

        getNumPatients()

        outFile = IO.File.AppendText(MAINFILE)
        If radA.Checked = True Then
            bloodType = "A"
        ElseIf radAB.Checked = True Then
            bloodType = "AB"
        ElseIf radB.Checked = True Then
            bloodType = "B"
        ElseIf radO.Checked = True Then
            bloodType = "O"
        Else
            'this will never happen because it will only writeToFile if all 
            'portions of the form are complete but it was giving a green squigly when 
            'bloodtype was reference in the writeLine method below
            bloodType = "N/A"
        End If



        outFile.WriteLine((numPatients + 1) & "|" _
                            & txtFirstName.Text & "|" _
                            & txtLastName.Text & "|" _
                            & ddlSex.SelectedItem.ToString() & "|" _
                            & txtAge.Text & "|" _
                            & txtHeight.Text & "|" _
                            & txtWeight.Text & "|" _
                            & txtTemp.Text & "|" _
                            & dtpDateVisited.Value & "|" _
                            & chkPregnant.Checked & "|" _
                            & bloodType & "|" _
                            & lstReason.SelectedItem.ToString())


        outFile.Close()
    End Sub

    Private Sub updateFile(patientID As Integer)
        Dim searchIndex As Integer = patientID
        Dim bloodType As String
        If radA.Checked = True Then
            bloodType = "A"
        ElseIf radAB.Checked = True Then
            bloodType = "AB"
        ElseIf radB.Checked = True Then
            bloodType = "B"
        ElseIf radO.Checked = True Then
            bloodType = "O"
        Else
            'this will never happen because it will only writeToFile if all 
            'portions of the form are complete but it was giving a green squigly when 
            'bloodtype was reference in the writeLine method below
            bloodType = "N/A"
        End If
        Dim newLine As String = (thePatient.patientID.ToString() & "|" _
                                    & txtFirstName.Text & "|" _
                                    & txtLastName.Text & "|" _
                                    & ddlSex.SelectedItem.ToString() & "|" _
                                    & txtAge.Text & "|" _
                                    & txtHeight.Text & "|" _
                                    & txtWeight.Text & "|" _
                                    & txtTemp.Text & "|" _
                                    & dtpDateVisited.Value & "|" _
                                    & chkPregnant.Checked.ToString() & "|" _
                                    & bloodType & "|" _
                                    & lstReason.SelectedItem.ToString())
        'read the lines into the array and when u get to the correct records, replace the line with updated data
        If System.IO.File.Exists(MAINFILE) Then
            Dim lines() As String = IO.File.ReadAllLines(MAINFILE)
            'search for the line that needs to be replaced
            For i As Integer = 0 To lines.Length - 1
                If i = searchIndex - 1 Then
                    lines(i) = newLine
                End If
            Next
            IO.File.WriteAllLines(MAINFILE, lines)
        End If


    End Sub
    Private Sub getNumPatients()
        Dim inFile As IO.StreamReader
        Dim line As String

        If IO.File.Exists(MAINFILE) Then
            'MsgBox("File found")
            inFile = File.OpenText(MAINFILE)


            Do Until inFile.Peek = -1
                line = inFile.ReadLine
                If line = "" Then
                    'nothing
                Else
                    numPatients += 1
                End If
            Loop
            inFile.Close()
        End If
    End Sub

    'KEY PRESS FOR FORM
    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        'Allows the backspace and space
        If e.KeyChar = ControlChars.Back OrElse e.KeyChar = " " Then
            Return
        End If

        ' Allows  Control-C, Control-V, and Control-X
        If e.KeyChar = ChrW(3) OrElse e.KeyChar = ChrW(22) OrElse e.KeyChar = ChrW(24) Then
            Return
        End If

        'allows letters
        If e.KeyChar >= "a" AndAlso e.KeyChar <= "z" OrElse e.KeyChar >= "A" AndAlso e.KeyChar <= "Z" Then
            Return
        End If

        'allows special characts that may be needed for names
        If e.KeyChar = "-" OrElse e.KeyChar = "'" Then
            Return
        End If

        e.Handled = True
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        'Allows the backspace and space
        If e.KeyChar = ControlChars.Back OrElse e.KeyChar = " " Then
            Return
        End If

        ' Allows  Control-C, Control-V, and Control-X
        If e.KeyChar = ChrW(3) OrElse e.KeyChar = ChrW(22) OrElse e.KeyChar = ChrW(24) Then
            Return
        End If

        'allows letters
        If e.KeyChar >= "a" AndAlso e.KeyChar <= "z" OrElse e.KeyChar >= "A" AndAlso e.KeyChar <= "Z" Then
            Return
        End If

        'allows special characts that may be needed for names
        If e.KeyChar = "-" OrElse e.KeyChar = "'" Then
            Return
        End If

        e.Handled = True
    End Sub

    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        'Allows the backspace
        If e.KeyChar = ControlChars.Back Then
            Return
        End If

        ' Allows  Control-C, Control-V, and Control-X
        If e.KeyChar = ChrW(3) OrElse e.KeyChar = ChrW(22) OrElse e.KeyChar = ChrW(24) Then
            Return
        End If
        'allows numbers
        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" Then
            Return
        End If

        e.Handled = True
    End Sub

    Private Sub txtHeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHeight.KeyPress
        'Allows the backspace
        If e.KeyChar = ControlChars.Back Then
            Return
        End If

        ' Allows  Control-C, Control-V, and Control-X
        If e.KeyChar = ChrW(3) OrElse e.KeyChar = ChrW(22) OrElse e.KeyChar = ChrW(24) Then
            Return
        End If
        'allows numbers
        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" Then
            Return
        End If

        'allows decimal
        If e.KeyChar = "." Then
            Return
        End If

        e.Handled = True
    End Sub

    Private Sub txtWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWeight.KeyPress
        'Allows the backspace
        If e.KeyChar = ControlChars.Back Then
            Return
        End If

        ' Allows  Control-C, Control-V, and Control-X
        If e.KeyChar = ChrW(3) OrElse e.KeyChar = ChrW(22) OrElse e.KeyChar = ChrW(24) Then
            Return
        End If
        'allows numbers
        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" Then
            Return
        End If

        e.Handled = True
    End Sub

    Private Sub txtTemp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTemp.KeyPress
        'Allows the backspace 
        If e.KeyChar = ControlChars.Back Then
            Return
        End If

        ' Allows  Control-C, Control-V, and Control-X
        If e.KeyChar = ChrW(3) OrElse e.KeyChar = ChrW(22) OrElse e.KeyChar = ChrW(24) Then
            Return
        End If
        'allows numbers
        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" Then
            Return
        End If

        'allows decimal
        If e.KeyChar = "." Then
            Return
        End If

        e.Handled = True
    End Sub


End Class
