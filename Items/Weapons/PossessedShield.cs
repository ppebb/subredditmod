using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
//using rterrariamod.Buffs;
//using rterrariamod.Projectiles.Summons;

/*
namespace rterrariamod.Items.Weapons
{
    public class PossessedShield : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons a Possessed Shield to defend you");
            ItemID.Sets.GamepadWholeScreenUseRange[item.type] = true;
            ItemID.Sets.LockOnIgnoresCollision[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.damage = 20;
            item.knockBack = 25f;
            item.mana = 10;
            item.useTime = 36;
            item.useAnimation = 36;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.value = Item.buyPrice(gold: 10);
            item.rare = ItemRarityID.LightRed;
            item.UseSound = SoundID.Item44;
            item.noMelee = true;
            item.summon = true;
            item.buffType = ModContent.BuffType<PossessedShieldBuff>();
            item.shoot = ModContent.ProjectileType<PossessedShieldSummon>();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            player.AddBuff(item.buffType, 2);
            position = Main.MouseWorld;
            return true;
        }
    }
}
*/