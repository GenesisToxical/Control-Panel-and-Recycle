Imports System.IO
Imports System.Threading

Public Class Form1

    Private Sub Add_P_Click(sender As Object, e As EventArgs) Handles Add_P.Click
        Add_P.Image = My.Resources.Add2
        Dim Objeto1 As Object
        Dim Objeto2 As Object
        Objeto1 = CreateObject("Scripting.FileSystemObject")
        Objeto2 = Objeto1.CreateTextFile("C:\Program Files\Control Panel and Recycle\ADP.bat", True)
        Objeto2.WriteLine("@echo off & reg add HKEY_CURRENT_USER\SOFTWARE\Classes\CLSID\{26EE0668-A00A-44D7-9371-BEB064C98683} /v System.IsPinnedToNameSpaceTree /t REG_DWORD /d 00000001 /f")
        Objeto2.Close()
        Shell("explorer.exe root = C:\Program Files\Control Panel and Recycle\ADP.bat")
        Thread.Sleep(3000)
        File.Delete("C:\Program Files\Control Panel and Recycle\ADP.bat")
    End Sub

    Private Sub Add_P_MouseEnter(sender As Object, e As EventArgs) Handles Add_P.MouseEnter
        Add_P.Image = My.Resources.Add2
    End Sub

    Private Sub Add_P_MouseLeave(sender As Object, e As EventArgs) Handles Add_P.MouseLeave
        Add_P.Image = My.Resources.Add1
    End Sub

    Private Sub Rem_P_Click(sender As Object, e As EventArgs) Handles Rem_P.Click
        Rem_P.Image = My.Resources.Remove2
        Dim Objeto1 As Object
        Dim Objeto2 As Object
        Objeto1 = CreateObject("Scripting.FileSystemObject")
        Objeto2 = Objeto1.CreateTextFile("C:\Program Files\Control Panel and Recycle\REP.bat", True)
        Objeto2.WriteLine("@echo off & reg delete HKEY_CURRENT_USER\SOFTWARE\Classes\CLSID\{26EE0668-A00A-44D7-9371-BEB064C98683} /f")
        Objeto2.Close()
        Shell("explorer.exe root = C:\Program Files\Control Panel and Recycle\REP.bat")
        Thread.Sleep(3000)
        File.Delete("C:\Program Files\Control Panel and Recycle\REP.bat")
    End Sub

    Private Sub Rem_P_MouseEnter(sender As Object, e As EventArgs) Handles Rem_P.MouseEnter
        Rem_P.Image = My.Resources.Remove2
    End Sub

    Private Sub Rem_P_MouseLeave(sender As Object, e As EventArgs) Handles Rem_P.MouseLeave
        Rem_P.Image = My.Resources.Remove1
    End Sub

    Private Sub Add_R_Click(sender As Object, e As EventArgs) Handles Add_R.Click
        Add_R.Image = My.Resources.Add2
        Dim Objeto1 As Object
        Dim Objeto2 As Object
        Objeto1 = CreateObject("Scripting.FileSystemObject")
        Objeto2 = Objeto1.CreateTextFile("C:\Program Files\Control Panel and Recycle\ADR.bat", True)
        Objeto2.WriteLine("@echo off & reg add HKEY_CURRENT_USER\SOFTWARE\Classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E} /v System.IsPinnedToNameSpaceTree /t REG_DWORD /d 00000001 /f")
        Objeto2.Close()
        Shell("explorer.exe root = C:\Program Files\Control Panel and Recycle\ADR.bat")
        Thread.Sleep(3000)
        File.Delete("C:\Program Files\Control Panel and Recycle\ADR.bat")
    End Sub

    Private Sub Add_R_MouseEnter(sender As Object, e As EventArgs) Handles Add_R.MouseEnter
        Add_R.Image = My.Resources.Add2
    End Sub

    Private Sub Add_R_MouseLeave(sender As Object, e As EventArgs) Handles Add_R.MouseLeave
        Add_R.Image = My.Resources.Add1
    End Sub

    Private Sub Rem_R_Click(sender As Object, e As EventArgs) Handles Rem_R.Click
        Rem_R.Image = My.Resources.Remove2
        Dim Objeto1 As Object
        Dim Objeto2 As Object
        Objeto1 = CreateObject("Scripting.FileSystemObject")
        Objeto2 = Objeto1.CreateTextFile("C:\Program Files\Control Panel and Recycle\RER.bat", True)
        Objeto2.WriteLine("@echo off & reg delete HKEY_CURRENT_USER\SOFTWARE\Classes\CLSID\{645FF040-5081-101B-9F08-00AA002F954E} /f")
        Objeto2.Close()
        Shell("explorer.exe root = C:\Program Files\Control Panel and Recycle\RER.bat")
        Thread.Sleep(3000)
        File.Delete("C:\Program Files\Control Panel and Recycle\RER.bat")
    End Sub

    Private Sub Rem_R_MouseEnter(sender As Object, e As EventArgs) Handles Rem_R.MouseEnter
        Rem_R.Image = My.Resources.Remove2
    End Sub

    Private Sub Rem_R_MouseLeave(sender As Object, e As EventArgs) Handles Rem_R.MouseLeave
        Rem_R.Image = My.Resources.Remove1
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("C:\Program Files\Control Panel and Recycle\About\About.html")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("C:\Program Files\Control Panel and Recycle\About\About.html")
    End Sub
End Class