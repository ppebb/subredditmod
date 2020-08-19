using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rterrariamod.Items
{
    public class ManaFruit : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Permanently increases maximum mana by 10\n'The fruit tastes sickeningly sweet'");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.maxStack = 99;
            item.consumable = true;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.useTime = 30;
            item.UseSound = SoundID.Item4;
            item.useAnimation = 30;
            item.rare = ItemRarityID.Lime;
            item.value = Item.sellPrice(gold: 2);
            item.color = Color.Purple;
        }

        public override bool CanUseItem(Player player)
        {
            return player.statManaMax == 200 && player.GetModPlayer<Rterrariaplayer>().manaFruits < Rterrariaplayer.maxManaFruits;
        }

        public override bool UseItem(Player player)
        {
            player.statManaMax2 += 10;
            player.statMana += 10;
            if (Main.myPlayer == player.whoAmI)
            {
                player.ManaEffect(10);
            }
            player.GetModPlayer<Rterrariaplayer>().manaFruits += 1;
            return true;
        }
    }
}
