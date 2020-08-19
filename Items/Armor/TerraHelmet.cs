using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace rterrariamod.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class TerraHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The pinnacle of creation\nIncreases melee damage by 5%\n5% increased meelee critical strike chance\nIncreases minion damage by 25%");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 25);
            item.rare = ItemRarityID.Lime;
            item.defense = 28;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<TerraBreastplate>() && legs.type == ItemType<TerraBoots>();
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += .05f;
            player.meleeCrit += 5;
            player.minionDamage += .25f;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = ("Increases damage by 30%\nIncreases movement speed by 30%");
            player.allDamage += .3f;
            player.moveSpeed += .3f;
        }
    }
}