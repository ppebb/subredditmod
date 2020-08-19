using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace rterrariamod.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class TrueNightsGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Night's Greaves");
            Tooltip.SetDefault("3% increased magic critical strike chance\n3% increased ranged damage\n2% increased damage");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 8);
            item.rare = ItemRarityID.Pink;
            item.defense = 12;
            item.manaIncrease = 20;
        }

        public override void UpdateEquip(Player player)
        {
            player.magicCrit += 3;
            player.rangedDamage += 0.03f;
            player.allDamage += 0.02f;
        }
    }
}
