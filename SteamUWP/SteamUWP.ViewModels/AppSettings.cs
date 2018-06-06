using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace SteamUWP.ViewModels
{
    public class AppSettings : INotifyPropertyChanged
    {
        public static AppSettings Instance { get; private set; } = Application.Current.Resources["AppSettings"] as AppSettings;

        /// <summary>
        /// 是否登录
        /// </summary>
        public bool IsSignIn { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
