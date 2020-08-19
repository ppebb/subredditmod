using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rterrariamod.Items
{
    public class TerraFragment : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 18;
            item.value = Item.sellPrice(silver: 750);
            item.rare = ItemRarityID.Lime;
            item.maxStack = 999;
        }
    }
}
