using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace rterrariamod.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class TrueNightsHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Night's Helmet");
            Tooltip.SetDefault("Increases maximum mana by 30\n3% increased magic critical strike chance\n3% increased ranged damage\n2% increased damage");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(gold: 8);
            item.rare = ItemRarityID.Pink;
            item.defense = 16;
            item.manaIncrease = 30;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<TrueNightsScalemail>() && legs.type == ItemType<TrueNightsGreaves>();
        }

        public override void UpdateEquip(Player player)
        {
            player.magicCrit += 3;
            player.rangedDamage += 0.03f;
            player.allDamage += 0.02f;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Reduces mana cost by 8%\n7% increased ranged critical strike chance\n8% extra melee damage";
            player.manaCost -= 0.08f;
            player.rangedCrit += 7;
            player.meleeDamage += 0.08f;
        }
    }
}