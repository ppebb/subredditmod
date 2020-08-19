using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace rterrariamod.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class TrueHallowedPlateMail : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("10% increased critical strike chance");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 7);
            item.rare = ItemRarityID.Pink;
            item.defense = 20;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeCrit = 10;
            player.magicCrit = 10;
            player.rangedCrit = 10;
            player.thrownCrit = 10;
        }
    }
}
