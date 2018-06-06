using Sago.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Steam.Domain
{
    public class Player : EntityBase
    {
        public Player(Guid identity) : base(identity)
        {

        }

        public string Name { get; set; }

        public Uri Avatar { get; set; }
    }
}
