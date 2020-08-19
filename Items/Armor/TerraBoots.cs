using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace rterrariamod.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class TerraBoots : ModItem
    {   
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The peak of existance\nIncreases magic damage by 10%\n15% increased critical strike chance");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = Item.sellPrice(gold: 15);
            item.rare = ItemRarityID.Lime;
            item.defense = 22;
            item.manaIncrease = 100;
        }

        public override void UpdateEquip(Player player)
        {
            player.magicDamage += .1f;
            player.magicCrit += 15;
        }
    }
}
