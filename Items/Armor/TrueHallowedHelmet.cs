using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace rterrariamod.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class TrueHallowedHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("10% increased ranged critical strike chance\n20% increased ranged damage");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 12);
            item.rare = ItemRarityID.Pink;
            item.defense = 13;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<TrueHallowedPlateMail>() && legs.type == ItemType<TrueHallowedGreaves>();
        }

        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += .2f;
            player.rangedCrit += 10;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "25% increased ranged damage";
            player.rangedDamage += .25f;
        }
    }
}
