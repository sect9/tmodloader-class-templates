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
    class $safeitemrootname$ : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("$safeitemrootname$ DisplayName");
            Tooltip.SetDefault("$safeitemrootname$ Tooltip");
        }

        public override void SetDefaults()
        { }

        public override void AddRecipes()
        { }
    }
}