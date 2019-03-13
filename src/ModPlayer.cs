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
    class $safeitemrootname$ : ModPlayer
    {
        public override void ResetEffects()
        { }

        public override void UpdateDead()
        { }

        public override TagCompound Save()
        {
            return new TagCompound {
                // To save more data, add additional lines

                /* { "Example", Example} */
            };
        }

        public override void Load(TagCompound tag)
        {
            // To load more data, add additional lines

            /* Example = tag.GetInt("Example"); */
        }
    }
}