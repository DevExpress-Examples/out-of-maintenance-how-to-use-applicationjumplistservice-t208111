using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Diagnostics;
using System.Windows.Media.Imaging;
using DevExpress.Xpf.Core;

namespace DXSampleApplicationJumpListService.ViewModel {
    [POCOViewModel]
    public class MainViewModel {
        protected IApplicationJumpListService ApplicationJumpListService { get { return this.GetService<IApplicationJumpListService>(); } }

        public void RunInternetExplorer() {
            Process.Start(@"C:\Program Files\Internet Explorer\iexplore.exe");
        }
        private void RunWindowsMediaPlayer() {
            Process.Start(@"C:\Program Files (x86)\Windows Media Player\wmplayer.exe");
        }
        public void AddItem() {
            ApplicationJumpListService.Items.AddOrReplace(
                "Media", 
                "Windows Media Player", 
             new BitmapImage(DXImageHelper.GetImageUri("Images/Miscellaneous/Video_16x16.png")),
                () => RunWindowsMediaPlayer()
            );
            ApplicationJumpListService.Apply();
        }
    }
}
