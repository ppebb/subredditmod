using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Graphics.Shaders;

namespace rterrariamod.Projectiles.Summons
{
    public class LongHairProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projPet[projectile.type] = true;
            projectile.ignoreWater = true;
            Main.projFrames[projectile.type] = 40;
        }

        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 34;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.timeLeft *= 5;
            projectile.tileCollide = true;
            projectile.netImportant = true;
        }

        public override bool? CanCutTiles()
        {
            return false;
        }
        public override bool PreAI()
        {
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            projectile.position = player.position;
        }
    }
}
