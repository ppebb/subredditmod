using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rterrariamod.Items
{
    public class MortarAndPestle : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.value = Item.sellPrice(silver: 50);
            item.useTurn = true;
            item.useTime = 15;
            item.useAnimation = 15;
            item.maxStack = 999;
            item.consumable = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.createTile = ModContent.TileType<Tiles.MortarAndPestleTile>();
        }
    }
}