using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rterrariamod.Items.Vanity
{
    [AutoloadEquip(EquipType.Head)]
    public class LongHair : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("I'm just making this to prove Ryan wrong");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(silver: 20);
        }

        public override void UpdateVanity(Player player, EquipType type)
        {
            player.GetModPlayer<RTerrariaPlayer>().longHair = true;
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = false;
            drawAltHair = false;
        }
    }
}
