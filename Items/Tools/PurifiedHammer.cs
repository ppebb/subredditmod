using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rterrariamod.Items.Tools
{
    public class PurifiedHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Smash an altar to obtain altar bits\nCrafted in the Hallow");
        }

        public override void SetDefaults()
        {
            item.damage = 28;
        }
    }
}
