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
    class $safeitemrootname$ : GlobalNPC
    {
        public override bool InstancePerEntity
        {
            get { return true; }
        }

        public override void ResetEffects(NPC npc)
        { }

        public override void SetDefaults(NPC npc)
        { }

        public override void NPCLoot(NPC npc)
        { }

        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        { }

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        { }

        public override void GetChat(NPC npc, ref string chat)
        { }
    }
}