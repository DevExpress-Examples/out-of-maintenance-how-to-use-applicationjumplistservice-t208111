Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataAnnotations
Imports System.Diagnostics
Imports System.Windows.Media.Imaging
Imports DevExpress.Xpf.Core

Namespace DXSampleApplicationJumpListService.ViewModel

    <POCOViewModel>
    Public Class MainViewModel

        Protected ReadOnly Property ApplicationJumpListService As IApplicationJumpListService
            Get
                Return GetService(Of IApplicationJumpListService)()
            End Get
        End Property

        Public Sub RunInternetExplorer()
            Call Process.Start("C:\Program Files\Internet Explorer\iexplore.exe")
        End Sub

        Private Sub RunWindowsMediaPlayer()
            Call Process.Start("C:\Program Files (x86)\Windows Media Player\wmplayer.exe")
        End Sub

        Public Sub AddItem()
            ApplicationJumpListService.Items.AddOrReplace("Media", "Windows Media Player", New BitmapImage(DXImageHelper.GetImageUri("Images/Miscellaneous/Video_16x16.png")), Sub() RunWindowsMediaPlayer())
            ApplicationJumpListService.Apply()
        End Sub
    End Class
End Namespace
