using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SteamUWP.ViewModels
{
    [DataContract]
    public class User
    {
        /// <summary>
        /// 头像
        /// </summary>
        [DataMember]
        public string Avatar { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
