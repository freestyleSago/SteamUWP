using SteamUWP.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Authentication.Web;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace SteamUWP.UI.Pages
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class SignInPage : Page
    {
        public SignInPage()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.Back)
            {
                return;
            }
            if (e.NavigationMode == NavigationMode.New)
            {
                await AuthenticationService.Authentic();
                //WebView.Navigate(AuthenticationService.MakeAuthenticationUri());
            }
        }

        private void WebView_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            //this.ProgressRing.IsActive = true;
            //if (args.Uri.Authority.ToLower() == AuthenticationService.REMLM.ToLower())
            //{
            //    this.WebView.Stop();
            //    var decodedUriString = WebUtility.UrlDecode(args.Uri.ToString());
            //    var regularExpression = new Regex("openid.identity=https:\\/\\/steamcommunity.com\\/openid\\/id\\/(\\d+)");
            //    if (regularExpression.IsMatch(decodedUriString))
            //    {
            //        var steamid = regularExpression.Match(decodedUriString).Groups[1].Value;
            //        this.Frame.Navigate(typeof(MainPage));
            //    }
            //    else
            //    {
                    
            //    }
            //}
        }

        private void WebView_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            //this.ProgressRing.IsActive = false;
        }
    }
}
