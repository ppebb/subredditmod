using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace rterrariamod.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class TrueHallowedMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("15% increased melee damage\n15% increased melee critical strike chance\n15% increased melee speed");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 12);
            item.rare = ItemRarityID.Pink;
            item.defense = 28;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<TrueHallowedPlateMail>() && legs.type == ItemType<TrueHallowedGreaves>();
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += .15f;
            player.meleeCrit += 15;
            player.meleeSpeed += .15f;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "20% increased melee and movement speed";
            player.meleeSpeed += .2f;
            player.moveSpeed += .2f;
        }
    }
}
