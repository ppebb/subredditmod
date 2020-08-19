using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace rterrariamod.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class TrueHallowedGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("10% increased damage\n15% increased movement speed");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.width = 18;
            item.value = Item.sellPrice(gold: 8);
            item.rare = ItemRarityID.Pink;
            item.defense = 15;
        }

        public override void UpdateEquip(Player player)
        {
            player.allDamage += .1f;
            player.moveSpeed += .15f;
        }
    }
}
