using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rterrariamod.Items.Tools
{
    public class PurifiedHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Smash an altar to obtain altar bits\nCrafted in the Hallow");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.melee = true;
            item.autoReuse = true;
            item.damage = 28;
            item.crit = 4;
            item.useTime = 27;
            item.useAnimation = 27;
            item.knockBack = 7.5f;
            item.hammer = 80;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.rare = ItemRarityID.LightRed;
            item.UseSound = SoundID.Item1;

        }
    }
}
