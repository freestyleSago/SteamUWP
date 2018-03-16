using SteamUWP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamUWP.Services
{
    public static class UserService
    {
        public static bool GetUserAsync()
        {
            ViewModel.Instance.User = new User()
            {
                Avatar = "ms-appx:///Assets/Images/avatar.jpg",
                Name = "XiZheng·Su"
            };
            return true;
        }
    }
}
