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
    class $safeitemrootname$ : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("$safeitemrootname$ DisplayName");
        }

        public override void SetDefaults()
        { }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        { }

        public override string TownNPCName()
        { }

        public override void SetupShop(Chest shop, ref int nextSlot)
        { }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        { }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        { }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        { }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        { }
    }
}