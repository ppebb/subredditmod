using Terraria;
using Terraria.ModLoader;
using rterrariamod.Projectiles.Summons;
using static Terraria.ModLoader.ModContent;

namespace rterrariamod.Buffs
{
    public class HeartLocketBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Heart Locket");
            Description.SetDefault("A clone is following you around");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<Rterrariaplayer>().HeartLocketSummon = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[ProjectileType<HeartLocketSummon>()] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, ProjectileType<HeartLocketSummon>(), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}