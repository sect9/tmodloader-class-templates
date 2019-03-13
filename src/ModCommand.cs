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
    class $safeitemrootname$ : ModCommand
    { 
        public override CommandType Type
        {
            get { return CommandType.Chat; }
        }

        public override string Command
        {
            get { return "$safeitemrootname$"; }
        }

        public override string Usage
        {
            get { return "/$safeitemrootname$"; }
        }

        public override string Description
        {
            get { return "$safeitemrootname$ template description"; }
        }

        public override void Action(CommandCaller caller, string input, string[] args)
        {
        }
    }
}