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
    class $safeitemrootname$ : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("$safeitemrootname$ DisplayName");
        }

        public override void SetDefaults()
        { }

        public virtual string GetName()
        {
            return "$safeitemrootname$ Name";
        }

        public override void AI()
        { }

        public virtual void PlaySound()
        { }

        public virtual void CreateDust()
        { }

        public override void OnHitPlayer(Player target, int damage, bool crit)
        { }
    }
}