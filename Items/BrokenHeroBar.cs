using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rterrariamod.Items
{
    public class BrokenHeroBar : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 24;
            item.value = Item.sellPrice(silver: 750);
            item.rare = ItemRarityID.Yellow;
            item.maxStack = 99;
        }
    }
}
