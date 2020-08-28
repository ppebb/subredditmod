using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rterrariamod.Items
{
    public class HoneyGlue : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'You might want to wash your hands'");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.maxStack = 999;
            item.value = Item.sellPrice(silver: 2);
            item.rare = ItemRarityID.Orange;
        }
    }
}
