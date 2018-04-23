﻿Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataAnnotations
Imports System
Imports System.Diagnostics
Imports System.Windows.Media.Imaging

Namespace DXSampleApplicationJumpListService.ViewModel
    <POCOViewModel> _
    Public Class MainViewModel
        Protected ReadOnly Property ApplicationJumpListService() As IApplicationJumpListService
            Get
                Return Me.GetService(Of IApplicationJumpListService)()
            End Get
        End Property

        Public Sub RunInternetExplorer()
            Process.Start("C:\Program Files\Internet Explorer\iexplore.exe")
        End Sub
        Private Sub RunWindowsMediaPlayer()
            Process.Start("C:\Program Files (x86)\Windows Media Player\wmplayer.exe")
        End Sub
        Public Sub AddItem()
            ApplicationJumpListService.Items.AddOrReplace("Media", "Windows Media Player", New BitmapImage(New Uri("pack://application:,,,/DevExpress.Images.v14.2;component/Office2013/Miscellaneous/Video_16x16.png", UriKind.Absolute)), Sub() RunWindowsMediaPlayer())
            ApplicationJumpListService.Apply()
        End Sub
    End Class
End Namespace
