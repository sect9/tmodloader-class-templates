using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Reflection;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace $rootnamespace$
{
    class $safeitemrootname$ : ModPrefix
    {
        public override float RollChance(Item item)
        {
            return 5f;
        }

        public override bool CanRoll(Item item)
        {
            return true;
        }

        public override PrefixCategory Category
        {
            get { return PrefixCategory.AnyWeapon; }
        }

        public $safeitemrootname$()
        { }

        public override void Apply(Item item)
        { }

        public override void ModifyValue(ref float valueMult)
        { }
    }
}