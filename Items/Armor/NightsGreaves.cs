using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rterrariamod.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class NightsGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Night's Greaves");
            Tooltip.SetDefault("Increases maximum mana by 20\n3% increased magic critical strike chance\n3% increased ranged damage\n2% increased damage");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 2);
            item.rare = ItemRarityID.Orange;
            item.defense = 8;
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