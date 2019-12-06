using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace YAATJ
{
    public class YAATJ : Mod
    {
        public YAATJ()
        {
        }
    }

    public class YAATJPlayer : ModPlayer
    {
        public override void OnEnterWorld(Player player)
        {
            base.OnEnterWorld(player);

            var team = GetInstance<YAATJConfig>().TeamToJoin;

            if (Main.player[Main.myPlayer].team == 0)
            {
                switch (team)
                {
                    case "Red":
                        Main.player[Main.myPlayer].team = 1;
                        break;
                    case "Green":
                        Main.player[Main.myPlayer].team = 2;
                        break;
                    case "Blue":
                        Main.player[Main.myPlayer].team = 3;
                        break;
                    case "Yellow":
                        Main.player[Main.myPlayer].team = 4;
                        break;
                    case "Pink":
                        Main.player[Main.myPlayer].team = 5;
                        break;
                    default:
                        Main.player[Main.myPlayer].team = 1;
                        break;
                }
            }
        }
    }
}