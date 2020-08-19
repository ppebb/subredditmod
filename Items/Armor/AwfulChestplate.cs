using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rterrariamod.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class AwfulChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases minion damage by 3%");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(silver: 25);
            item.rare = ItemRarityID.Blue;
            item.defense = 1;
        }

        public override void UpdateEquip(Player player)
        {
            player.minionDamage += .03f;
        }
    }
}
