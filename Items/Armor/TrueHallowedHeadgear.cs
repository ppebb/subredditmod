using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace rterrariamod.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class TrueHallowedHeadgear : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases maximum mana by 125\n18% increased magic critical strike chance\n18% increased magic damage");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 12);
            item.rare = ItemRarityID.Pink;
            item.defense = 12;
            item.manaIncrease = 125;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<TrueHallowedPlateMail>() && legs.type == ItemType<TrueHallowedGreaves>();
        }

        public override void UpdateEquip(Player player)
        {
            player.magicDamage += .18f;
            player.magicCrit += 18;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "25% reduced mana cost";
            player.manaCost -= .25f;
        }
    }
}
