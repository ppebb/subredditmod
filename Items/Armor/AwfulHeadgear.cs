using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using System.Security.Cryptography.X509Certificates;

namespace rterrariamod.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class AwfulHeadgear : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases minion damage by 2%");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(silver: 20);
            item.rare = ItemRarityID.Blue;
            item.defense = 1;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<AwfulChestplate>() && legs.type == ItemType<AwfulBoots>();
        }

        public override void UpdateEquip(Player player)
        {
            player.minionDamage += .02f;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increases minion damage by 5%\nIncreases your max number of minions by 1";
            player.minionDamage += .05f;
            player.maxMinions += 1;
        }
    }
}
