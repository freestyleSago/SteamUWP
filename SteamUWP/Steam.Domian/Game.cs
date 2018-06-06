using Sago.Framework.Domain;
using System;
using System.Runtime.Serialization;

namespace Steam.Domain
{
    /// <summary>
    /// 游戏
    /// </summary>
    [DataContract]
    public class Game : ValueObjectBase
    {
        protected Game(string appID, string name, Uri icon, Uri logo)
        {
            this.AppID = appID;
            this.Name = name;
            this.Icon = icon;
            this.Logo = logo;
        }

        /// <summary>
        /// 游戏ID
        /// </summary>
        [DataMember(Name = "appid")]
        public string AppID { get; private set; }

        /// <summary>
        /// 游戏名
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; private set; }

        ///// <summary>
        ///// 玩游戏时长
        ///// </summary>
        //[DataMember(Name = "playtime_forever")]
        //public string Playtime_Forever { get; private set; }

        /// <summary>
        /// 游戏ICON
        /// </summary>
        [DataMember(Name = "img_icon_url")]
        public Uri Icon { get; private set; }

        /// <summary>
        /// 游戏Logo
        /// </summary>
        [DataMember(Name = "img_logo_url")]
        public Uri Logo { get; private set; }
    }
}
