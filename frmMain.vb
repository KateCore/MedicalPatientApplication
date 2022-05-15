'******************************************************
'* Name:       Katelyn Correa
'* Class:      CIS-1510
'* Assignment: Project2 Fall 2020
'* File:       frmMain.vb
'* Purpose:    Display records and act as a menu
'******************************************************

Option Strict On
Option Explicit On
Option Infer Off
Option Compare Binary

Imports System.IO
Imports System.Text
Public Class frmMain
    Private Const MAINFILE As String = "patientData.txt"

    'initialize array of objects
    Public recordsArr(999) As Patient
    Public numPatients As Integer = 0
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadRecords()
        displayRecords()
        '
    End Sub
    'BUTTONS
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Dim newPatient As Patient = New Patient()
        Dim newPatientfrm As frmPatient = New frmPatient(newPatient, True)

        newPatientfrm.ShowDialog()
        loadRecords()
        lstRecords.Items.Clear()
        displayRecords()
        gbxPatientDetails.Visible = False

    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim index As Integer
        Dim newPatientFrm As frmPatient
        If lstRecords.SelectedIndex = -1 Then
            MsgBox("You must select a record to update first!", MsgBoxStyle.Exclamation, "Error!")
        Else
            index = lstRecords.SelectedIndex
            newPatientFrm = New frmPatient(recordsArr(index), False)

            newPatientFrm.ShowDialog()
            loadRecords()
            lstRecords.Items.Clear()
            displayRecords()
            gbxPatientDetails.Visible = False
        End If
    End Sub
    'double click is the same as clicking btnUpdate
    Private Sub lstRecords_DoubleClick(sender As Object, e As EventArgs) Handles lstRecords.DoubleClick
        Dim index As Integer
        Dim newPatientFrm As frmPatient
        If lstRecords.SelectedIndex = -1 Then
            MsgBox("You must select a record to update first!")
        Else
            index = lstRecords.SelectedIndex
            newPatientFrm = New frmPatient(recordsArr(index), False)

            newPatientFrm.ShowDialog()
            loadRecords()
            lstRecords.Items.Clear()
            displayRecords()
            gbxPatientDetails.Visible = False
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim newAboutfrm As frmAbout = New frmAbout()

        newAboutfrm.ShowDialog()
    End Sub

    'OTHER METHODS
    Private Sub lstRecords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRecords.SelectedIndexChanged
        displayPatient()
    End Sub
    'load existing records
    Private Sub loadRecords()
        Dim inFile As IO.StreamReader
        Dim line As String
        Dim splitLine As String()
        Dim index As Integer

        numPatients = 0
        index = numPatients


        If IO.File.Exists(MAINFILE) Then
            'MsgBox("File found")
            inFile = File.OpenText(MAINFILE)

            Do Until inFile.Peek = -1
                recordsArr(numPatients) = New Patient()
                line = inFile.ReadLine

                If (line.Contains("|")) Then
                    splitLine = line.Split("|"c)
                    recordsArr(index).patientID = Convert.ToInt32(splitLine(0))
                    recordsArr(index).firstName = splitLine(1)
                    recordsArr(index).lastName = splitLine(2)
                    recordsArr(index).sex = splitLine(3)
                    recordsArr(index).age = Convert.ToInt32(splitLine(4))
                    recordsArr(index).height = Convert.ToDecimal(splitLine(5))
                    recordsArr(index).weight = Convert.ToInt32(splitLine(6))
                    recordsArr(index).temperature = Convert.ToDecimal(splitLine(7))
                    recordsArr(index).dateVisited = Convert.ToDateTime(splitLine(8))
                    recordsArr(index).pregnant = Convert.ToBoolean(splitLine(9))
                    recordsArr(index).bloodType = splitLine(10)
                    recordsArr(index).reason = splitLine(11)

                    index += 1
                    numPatients += 1

                End If


            Loop
            inFile.Close()
        Else
            MsgBox("There is no data available. Add Patient to create deata!")

        End If
    End Sub

    Private Sub displayRecords()
        Dim counter As Integer
        Dim index As Integer = 0

        For counter = 0 To (numPatients - 1)
            lstRecords.Items.Add(recordsArr(index).patientID.ToString().PadRight(4) _
                                 & recordsArr(index).firstName.ToUpper.PadRight(15) _
                                 & recordsArr(index).lastName.ToUpper.PadRight(15) _
                                 & recordsArr(index).dateVisited.ToString().PadRight(10))
            index += 1

        Next
    End Sub

    Private Sub displayPatient()
        Dim index As Integer

        index = lstRecords.SelectedIndex
        If index = -1 Then
            MsgBox("Please choose a valid record to view.", MsgBoxStyle.Exclamation, "Error!")
            Return
        End If
        lblDateOfVisit.Text = recordsArr(index).dateVisited.ToString()
        lblFirstName.Text = recordsArr(index).firstName.ToUpper
        lblLastName.Text = recordsArr(index).lastName.ToUpper
        lblAge.Text = recordsArr(index).age.ToString()
        lblSex.Text = recordsArr(index).sex
        lblHeight.Text = recordsArr(index).height.ToString()
        lblWeight.Text = recordsArr(index).weight.ToString()
        lblTemp.Text = recordsArr(index).temperature.ToString()
        lblBloodType.Text = recordsArr(index).bloodType
        lblReason.Text = recordsArr(index).reason
        If recordsArr(index).pregnant = True Then
            lblPregnant.Text = "Yes"
        Else
            lblPregnant.Text = "No"
        End If

        ' make the gbx visible
        gbxPatientDetails.Visible = True


    End Sub


End Class