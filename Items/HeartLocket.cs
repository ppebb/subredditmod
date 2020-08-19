using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using rterrariamod.Buffs;
using rterrariamod.Projectiles.Summons;
using static Terraria.ModLoader.ModContent;

namespace rterrariamod.Items
{
    public class HeartLocket : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons a clone that follows you around\n'Twinsies!'");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.damage = 0;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item2;
            item.useAnimation = 20;
            item.useTime = 20;
            item.noMelee = true;
            item.rare = ItemRarityID.White;
            item.value = Item.sellPrice(gold: 20);
            item.buffType = BuffType<HeartLocketBuff>();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(player.position.X + 32, player.position.Y - 32, speedX, speedY, ProjectileType<HeartLocketSummon>(), 0, 0, player.whoAmI);
            return true;
        }

        public override bool CanBurnInLava()
        {
            return false;
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}
