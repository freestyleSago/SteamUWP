using IdentityModel.OidcClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using Windows.Security.Authentication.Web;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace SteamUWP.Services
{
    /// <summary>
    /// 认证服务
    /// </summary>
    public static class AuthenticationService
    {
        public const string REMLM = "SteamUWP.com";
        private const string AuthenticationURI = "https://steamcommunity.com/openid/login?openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&openid.mode=checkid_setup&openid.return_to=https%3A%2F%2Fwww.steamgifts.com%2F%3Flogin&openid.realm=https%3A%2F%2Fwww.steamgifts.com&openid.ns.sreg=http%3A%2F%2Fopenid.net%2Fextensions%2Fsreg%2F1.1&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select";
        /// <summary>
        /// 认证
        /// </summary>
        /// <returns></returns>
        public static async Task<bool> Authentic()
        {
            var result = await WebAuthenticationBroker.AuthenticateAsync(WebAuthenticationOptions.UseTitle, MakeAuthenticationUri());
            //var webView = new WebView();
            //var progressRing = new ProgressRing() { IsActive = true };
            //var root = new Grid();
            //root.Children.Add(webView);
            //root.Children.Add(progressRing);
            //var authenticDialog = new ContentDialog
            //{
            //    Content = root,
            //    CloseButtonText = ResourceLoader.GetForCurrentView().GetString("SignInPage_SigninDialog_CloseButtonText"),
            //    Title = ResourceLoader.GetForCurrentView().GetString("SignInPage_SigninDialog_Title")
            //};
            //await authenticDialog.ShowAsync();

            //webView.NavigationStarting += WebView_NavigationStarting;
            //webView.NavigationFailed += WebView_NavigationFailed;
            return true;
        }

        private static void WebView_NavigationFailed(object sender, WebViewNavigationFailedEventArgs e)
        {
        }

        private static void WebView_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
        }

        private static Uri MakeAuthenticationUri()
        {
            var uriStringBuilder = new StringBuilder("https://steamcommunity.com/openid/login");
            uriStringBuilder.AppendFormat("?openid.ns={0}", "http://specs.openid.net/auth/2.0");
            uriStringBuilder.AppendFormat("&openid.mode={0}", "checkid_setup");
            //uriStringBuilder.AppendFormat("&openid.return_to={0}", $"https://{AuthenticationService.REMLM}/signin");
            //uriStringBuilder.AppendFormat("&openid.realm={0}", $"https://{AuthenticationService.REMLM}");
            uriStringBuilder.AppendFormat("&openid.return_to={0}", $"{WebAuthenticationBroker.GetCurrentApplicationCallbackUri().ToString()}");
            uriStringBuilder.AppendFormat("&openid.realm={0}", $"{WebAuthenticationBroker.GetCurrentApplicationCallbackUri().ToString()}");
            uriStringBuilder.AppendFormat("&openid.identity={0}", "http://specs.openid.net/auth/2.0/identifier_select");
            uriStringBuilder.AppendFormat("&openid.claimed_id={0}", "http://specs.openid.net/auth/2.0/identifier_select");

            if (Uri.TryCreate(uriStringBuilder.ToString(), UriKind.Absolute, out Uri uri))
            {
                return uri;
            }
            return default(Uri);
        }
    }
}
