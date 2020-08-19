using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace rterrariamod.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class TerraBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The culmanation of power\nIncreases ranged damage by 5%\n10% increased critical strike chance\nReduces ammo consumption by 20%");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 20);
            item.rare = ItemRarityID.Lime;
            item.defense = 24;
        }

        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += .05f;
            player.rangedCrit += 10;
            player.ammoCost80 = true;
        }
    }
}
