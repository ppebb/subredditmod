using Terraria;
using Terraria.ModLoader;

namespace rterrariamod.Items
{
    public class CrystalPowder : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Don't snort these'");
        }
        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.maxStack = 999;
        }
    }
}
