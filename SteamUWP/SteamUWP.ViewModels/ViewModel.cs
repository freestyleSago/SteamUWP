using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;

namespace SteamUWP.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        public static ViewModel Instance { get; private set; } = Application.Current.Resources["ViewModel"] as ViewModel;

        private User user;
        /// <summary>
        /// 用户
        /// </summary>
        public User User
        {
            get
            {
                return this.user;
            }
            set
            {
                this.user = value;
                this.NotifyPropertyChanged();
            }
        }

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
