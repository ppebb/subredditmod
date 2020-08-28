using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Graphics.Shaders;

namespace rterrariamod.Projectiles.Summons
{
    public class HeartLocketSummon : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Clone");
            Main.projPet[projectile.type] = true;
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
        #region Public Variables
        public int frameCounter = 0;
        public int frameMultiplier = 6;
        public int balloonCounter = 0;
        public int balloonMultiplier = 0;
        public SpriteEffects spriteDirection;
        public Vector2 drawCenter = new Vector2(22f, 18f);
        public Vector2 hairOffset = new Vector2(22f, 18f);
        public Rectangle defaultframe = new Rectangle(0, 0, 40, 56);
        public Rectangle hairframe = new Rectangle(0, 0, 40, 56);
        public Rectangle balloonframe = new Rectangle(0, 0, 56, 56);
        #endregion
        public override void AI()
        {
            #region Active Check
            Player player = Main.player[projectile.owner];
            RTerrariaPlayer modPlayer = player.GetModPlayer<RTerrariaPlayer>();
            if (player.dead)
                modPlayer.HeartLocketSummon = false;
            if (modPlayer.HeartLocketSummon)
                projectile.timeLeft = 2;
            #endregion

            #region General Behavior
            projectile.velocity.Y += modPlayer.projGravity;
            Vector2 vectorToIdlePosition = player.Center - projectile.Center;
            float distanceToIdlePosition = vectorToIdlePosition.Length();
            if (Main.myPlayer == player.whoAmI && distanceToIdlePosition > 2000f && player.velocity.Y == 0f)
            {
                Main.PlaySound(SoundID.Item6, (int)projectile.Center.X, (int)projectile.Center.Y);
                projectile.position = player.Center;
                projectile.velocity *= 0f;
                projectile.netUpdate = true;
                for (int num325 = 0; num325 < 20; num325++)
                    Dust.NewDust(projectile.position, projectile.width, projectile.height, 15, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f, 150, default, 1.5f);
            }
            #endregion

            #region Floor Speed Change
            bool floorCheckBool = false;
            Tile[] floorArray = new Tile[3];
            floorArray[0] = Framing.GetTileSafely(projectile.Center + new Vector2(-10, 19));
            floorArray[1] = Framing.GetTileSafely(projectile.Center + new Vector2(0, 19));
            floorArray[2] = Framing.GetTileSafely(projectile.Center + new Vector2(10, 19));
            for (int c = 0; c < floorArray.Length; c++)
            {
                Tile fTile = floorArray[c];
                if (fTile.type == TileID.HoneyBlock)
                {
                    modPlayer.projJumpSpeed += 20f;
                    modPlayer.projJumpSpeed /= 5f;
                    modPlayer.projMaxRunSpeed *= 0.25f;
                    modPlayer.projRunAcceleration *= 0.25f;
                    modPlayer.projRunSlowdown *= 2f;
                    if (projectile.velocity.X > modPlayer.projMaxRunSpeed)
                        projectile.velocity.X = modPlayer.projMaxRunSpeed;
                    if (projectile.velocity.X < 0f - modPlayer.projMaxRunSpeed)
                        projectile.velocity.X = 0f - modPlayer.projMaxRunSpeed;
                    break;
                }
                else if (fTile.type == TileID.Asphalt)
                {
                    modPlayer.projMaxRunSpeed *= 3.5f;
                    modPlayer.projRunAcceleration *= 1f;
                    modPlayer.projRunSlowdown *= 2f;
                    break;
                }
                else if (fTile.type == TileID.IceBlock || fTile.type == TileID.BreakableIce || fTile.type == TileID.CorruptIce || fTile.type == TileID.HallowedIce)
                {
                    modPlayer.projSlippy = true;
                    modPlayer.projRunAcceleration *= 0.7f;
                    if (player.iceSkate)
                    {
                        modPlayer.projRunAcceleration *= 3.5f;
                        modPlayer.projMaxRunSpeed *= 1.25f;
                        break;
                    }
                }
                else if (fTile.type == TileID.FrozenSlimeBlock)
                {
                    modPlayer.projSlippy2 = true;
                    modPlayer.projRunAcceleration *= 0.6f;
                    modPlayer.projRunSlowdown = 0f;
                    if (player.iceSkate)
                    {
                        modPlayer.projRunAcceleration *= 3.5f;
                        modPlayer.projMaxRunSpeed *= 1.25f;
                    }
                    break;
                }
                if (fTile.active() && Main.tileSolid[fTile.type])
                {
                    floorCheckBool = true;
                    break;
                }
                if (modPlayer.lRHoney && fTile.type != TileID.HoneyBlock)
                {
                    defaultframe = new Rectangle(0, 280, 40, 56);
                    break;
                }
            }
            #endregion

            #region Sideways Speed Change
            bool shouldJump = false;
            Tile[] leftRightArray = new Tile[4];
            leftRightArray[0] = Framing.GetTileSafely(projectile.Center + new Vector2(14, 0));
            leftRightArray[1] = Framing.GetTileSafely(projectile.Center + new Vector2(-14, 0));
            leftRightArray[2] = Framing.GetTileSafely(projectile.Center + new Vector2(14, -8));
            leftRightArray[3] = Framing.GetTileSafely(projectile.Center + new Vector2(-14, -8));
            for (int lR = 0; lR < leftRightArray.Length; lR++)
            {
                Tile tileLR = leftRightArray[lR];
                if (tileLR.type == TileID.HoneyBlock)
                {
                    modPlayer.lRHoney = true;
                    if (projectile.velocity.X > 1f)
                        projectile.velocity.X = 1f;
                    if (projectile.velocity.X < -1f)
                        projectile.velocity.X = -1f;
                    if (projectile.velocity.Y > 1f)
                        projectile.velocity.Y = 1f;
                    if (projectile.velocity.Y < -5f)
                        projectile.velocity.Y = -5f;
                    if (projectile.velocity.X > 0.75 || projectile.velocity.X < -0.75)
                        projectile.velocity.X *= 0.85f;
                    else
                        projectile.velocity.X *= 0.6f;
                    if (projectile.velocity.Y < 0f)
                        projectile.velocity.Y *= 0.96f;
                    else
                        projectile.velocity.Y *= 0.3f;
                    break;
                }
                if (tileLR.active() && Main.tileSolid[tileLR.type])
                {
                    shouldJump = true;
                    break;
                }

            }
            if (player.sandStorm)
            {
                modPlayer.projWindPushed = true;
                modPlayer.projRunAcceleration *= 1.5f;
                modPlayer.projMaxRunSpeed *= 2f;
            }
            if (projectile.wetCount > .35f)
            {
                if (projectile.honeyWet)
                {
                    modPlayer.projGravity = 0.1f;
                    modPlayer.projMaxFallSpeed = 3f;
                }
                else
                {
                    modPlayer.projGravity = 0.2f;
                    modPlayer.projMaxFallSpeed = 5f;
                    modPlayer.projJumpSpeed = 6.01f;
                }
            }
            #endregion

            #region Floor Dust
            Tile tile = Framing.GetTileSafely(projectile.Center + new Vector2(0, 19));
            bool Falling = false;
            if (projectile.oldVelocity.Y != 0)
                Falling = true;
            if (tile.type == 147 || tile.type == 25 || tile.type == 53 || tile.type == 189 || tile.type == 123 || tile.type == 57 || tile.type == 112 || tile.type == 116 || tile.type == 196 || tile.type == 193 || tile.type == 195 || tile.type == TileID.FrozenSlimeBlock || tile.type == 199 || tile.type == 229 || tile.type == 371)
            {
                int dustCount = 1;
                if (Falling)
                    dustCount = 20;
                for (int i = 0; i < dustCount; i++)
                {
                    bool flag = true;
                    int dustType = 76;
                    if (tile.type == TileID.Sand)
                        dustType = 32;
                    if (tile.type == TileID.Cloud)
                        dustType = 16;
                    if (tile.type == TileID.Dirt)
                        dustType = 0;
                    if (tile.type == TileID.Silt)
                        dustType = 53;
                    if (tile.type == TileID.Ash)
                        dustType = 36;
                    if (tile.type == TileID.Ebonsand)
                        dustType = 14;
                    if (tile.type == TileID.Pearlsand)
                        dustType = 51;
                    if (tile.type == TileID.RainCloud)
                        dustType = 108;
                    if (tile.type == TileID.SlimeBlock)
                        dustType = 4;
                    if (tile.type == TileID.FleshBlock || tile.type == TileID.FleshGrass)
                        dustType = 5;
                    if (tile.type == TileID.FrozenSlimeBlock)
                        dustType = 4;
                    if (tile.type == TileID.HoneyBlock)
                        dustType = 153;
                    if (tile.type == TileID.PinkSlimeBlock)
                        dustType = 243;
                    if (tile.type == TileID.Ebonstone)
                        dustType = 37;
                    if (dustType == 32 && Main.rand.Next(2) == 0)
                        flag = false;
                    if (dustType == 14 && Main.rand.Next(2) == 0)
                        flag = false;
                    if (dustType == 51 && Main.rand.Next(2) == 0)
                        flag = false;
                    if (dustType == 36 && Main.rand.Next(2) == 0)
                        flag = false;
                    if (dustType == 0 && Main.rand.Next(3) != 0)
                        flag = false;
                    if (dustType == 53 && Main.rand.Next(3) != 0)
                        flag = false;
                    Color newColor = default;
                    if (tile.type == TileID.SlimeBlock)
                        newColor = new Color(30, 100, 255, 100);
                    if (tile.type == TileID.FrozenSlimeBlock)
                        newColor = new Color(97, 200, 255, 100);
                    TileLoader.WalkDust(tile.type, ref dustType, ref flag, ref newColor);
                    if (!Falling)
                    {
                        float num3 = System.Math.Abs(projectile.velocity.X) / 3f;
                        if (Main.rand.Next(100) > num3 * 100f)
                            flag = false;
                    }
                    if (!flag)
                        continue;
                    float velocityIThink = projectile.velocity.X;
                    if (velocityIThink > 6f)
                        velocityIThink = 6f;
                    if (velocityIThink < -6f)
                        velocityIThink = -6f;
                    if (!(projectile.velocity.X != 0f || Falling))
                        continue;
                    int floorDust = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + projectile.height - 2f), projectile.width, 6, dustType, 0f, 0f, 50, newColor);
                    if (dustType == 76)
                    {
                        Main.dust[floorDust].scale += Main.rand.Next(3) * 0.1f;
                        Main.dust[floorDust].noLight = true;
                    }
                    if (dustType == 16 || dustType == 108 || dustType == 153)
                        Main.dust[floorDust].scale += Main.rand.Next(6) * 0.1f;
                    if (dustType == 37)
                    {
                        Main.dust[floorDust].scale += 0.25f;
                        Main.dust[floorDust].alpha = 50;
                    }
                    if (dustType == 5)
                        Main.dust[floorDust].scale += Main.rand.Next(2, 8) * 0.1f;
                    Main.dust[floorDust].noGravity = true;
                    if (dustCount > 1)
                    {
                        Main.dust[floorDust].velocity.X *= 1.2f;
                        Main.dust[floorDust].velocity.Y *= 0.8f;
                        Main.dust[floorDust].velocity.Y -= 1f;
                        Main.dust[floorDust].velocity *= 0.8f;
                        Main.dust[floorDust].scale += Main.rand.Next(3) * 0.1f;
                        Main.dust[floorDust].velocity.X = (Main.dust[floorDust].position.X - (projectile.position.X + (projectile.width / 2))) * 0.2f;
                        if (Main.dust[floorDust].velocity.Y > 0f)
                            Main.dust[floorDust].velocity.Y *= -1f;

                        Main.dust[floorDust].velocity.X += velocityIThink * 0.3f;
                    }
                    else
                        Main.dust[floorDust].velocity *= 0.2f;
                    Main.dust[floorDust].position.X -= velocityIThink * 1f;
                }
            }
            #endregion

            #region Wall Dust
            int num100 = projectile.width / 2;
            int num102 = projectile.height / 2;
            new Vector2(projectile.position.X + (projectile.width / 2) - (num100 / 2), projectile.position.Y + (projectile.height / 2) - (num102 / 2));
            Vector2 vector = Collision.StickyTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);
            if (vector.Y != -1f && vector.X != -1f && projectile.oldVelocity.Y != 0)
            {
                int num3 = (int)vector.X;
                int num4 = (int)vector.Y;
                if (Main.rand.Next(5) != 0 || (!(projectile.velocity.Y > 0.15) && !(projectile.velocity.Y < 0f)))
                    return;
                if ((num3 * 16) < projectile.position.X + (projectile.width / 2))
                {
                    int num5 = Dust.NewDust(new Vector2(projectile.position.X - 4f, num4 * 16), 4, 16, 153, 0f, 0f, 50);
                    Main.dust[num5].scale += Main.rand.Next(0, 6) * 0.1f;
                    Main.dust[num5].velocity *= 0.1f;
                    Main.dust[num5].noGravity = true;
                }
                else
                {
                    int num6 = Dust.NewDust(new Vector2(projectile.position.X + projectile.width - 2f, num4 * 16), 4, 16, 153, 0f, 0f, 50);
                    Main.dust[num6].scale += Main.rand.Next(0, 6) * 0.1f;
                    Main.dust[num6].velocity *= 0.1f;
                    Main.dust[num6].noGravity = true;
                }
                if (Main.tile[num3, num4 + 1] != null && Main.tile[num3, num4 + 1].type == 229 && projectile.position.Y + projectile.height > ((num4 + 1) * 16))
                {
                    if ((num3 * 16) < projectile.position.X + (projectile.width / 2))
                    {
                        int num7 = Dust.NewDust(new Vector2(projectile.position.X - 4f, num4 * 16 + 16), 4, 16, 153, 0f, 0f, 50);
                        Main.dust[num7].scale += Main.rand.Next(0, 6) * 0.1f;
                        Main.dust[num7].velocity *= 0.1f;
                        Main.dust[num7].noGravity = true;
                    }
                    else
                    {
                        int num8 = Dust.NewDust(new Vector2(projectile.position.X + projectile.width - 2f, num4 * 16 + 16), 4, 16, 153, 0f, 0f, 50);
                        Main.dust[num8].scale += Main.rand.Next(0, 6) * 0.1f;
                        Main.dust[num8].velocity *= 0.1f;
                        Main.dust[num8].noGravity = true;
                    }
                }
                if (Main.tile[num3, num4 + 2] != null && Main.tile[num3, num4 + 2].type == 229 && projectile.position.Y + projectile.height > ((num4 + 2) * 16))
                {
                    if ((num3 * 16) < projectile.position.X + (projectile.width / 2))
                    {
                        int num9 = Dust.NewDust(new Vector2(projectile.position.X - 4f, num4 * 16 + 32), 4, 16, 153, 0f, 0f, 50);
                        Main.dust[num9].scale += Main.rand.Next(0, 6) * 0.1f;
                        Main.dust[num9].velocity *= 0.1f;
                        Main.dust[num9].noGravity = true;
                    }
                    else
                    {
                        int num10 = Dust.NewDust(new Vector2(projectile.position.X + projectile.width - 2f, num4 * 16 + 32), 4, 16, 153, 0f, 0f, 50);
                        Main.dust[num10].scale += Main.rand.Next(0, 6) * 0.1f;
                        Main.dust[num10].velocity *= 0.1f;
                        Main.dust[num10].noGravity = true;
                    }
                }
            }
            #endregion

            #region Movement
            int chillCounter = 1800;
            if (projectile.wet && !projectile.honeyWet && !projectile.lavaWet && player.ZoneSnow)
            {
                chillCounter = 0;
                chillCounter++;
            }
            if (chillCounter < 1800)
                modPlayer.projMaxRunSpeed *= 0.75f;
            if (vectorToIdlePosition.X < -96 && projectile.velocity.X > 0f - modPlayer.projMaxRunSpeed)
            {
                if (projectile.velocity.X > modPlayer.projRunSlowdown)
                    projectile.velocity.X -= modPlayer.projRunSlowdown;
                projectile.velocity.X -= modPlayer.projRunAcceleration;
            }
            else if (vectorToIdlePosition.X > 96 && projectile.velocity.X < modPlayer.projMaxRunSpeed)
            {
                if (projectile.velocity.X < 0f - modPlayer.projRunSlowdown)
                    projectile.velocity.X += modPlayer.projRunSlowdown;
                projectile.velocity.X += modPlayer.projRunAcceleration;
            }
            if (vectorToIdlePosition.X < 96 && vectorToIdlePosition.X > 0 && !modPlayer.projSlippy && !modPlayer.projSlippy2)
            {
                if (projectile.velocity.X > .25f)
                    projectile.velocity.X -= .25f;
                if (projectile.velocity.X < .25f && projectile.velocity.X > 0)
                    projectile.velocity.X = 0;
            }
            if (vectorToIdlePosition.X > -96 && !modPlayer.projSlippy && !modPlayer.projSlippy2)
            {
                if (projectile.velocity.X < -.25f)
                    projectile.velocity.X += .25f;
                if (projectile.velocity.X > -.25f && projectile.velocity.X < 0)
                    projectile.velocity.X = 0;
            }
            #endregion

            #region Jump & StepUp
            if (floorCheckBool && shouldJump && distanceToIdlePosition > 96)
                projectile.velocity.Y = 0f - modPlayer.projJumpSpeed;

            if (floorCheckBool || projectile.wet)
            {
                Collision.StepUp(ref projectile.position, ref projectile.velocity, projectile.width, projectile.height, ref projectile.stepSpeed, ref projectile.gfxOffY);
                if (projectile.velocity.Y == 0f)
                {
                    if (projectile.velocity.X < 0f || projectile.velocity.X > 0f)
                    {
                        int stepX = (int)(projectile.position.X + (projectile.width / 2)) / 16;
                        int stepY = (int)(projectile.position.Y + (projectile.height / 2)) / 16 + 1;
                        WorldGen.SolidTile(stepX, stepY);
                    }
                }
            }
            if (projectile.velocity.Y > modPlayer.projMaxFallSpeed)
                projectile.velocity.Y = modPlayer.projMaxFallSpeed;
            #endregion

            #region Animation
            balloonCounter++;
            if (balloonCounter > 6)
            {
                balloonMultiplier++;
                balloonCounter = 0;
                if (balloonMultiplier > 5)
                    balloonMultiplier = 0;
            }
            balloonframe = new Rectangle(0, 56 * balloonMultiplier, 56, 56);
            if (projectile.velocity.X < 0)
            {
                spriteDirection = SpriteEffects.FlipHorizontally;
                drawCenter = new Vector2(22f, 18f);
            }
            else if (projectile.velocity.X > 0)
                spriteDirection = SpriteEffects.None;
            if (projectile.velocity.X == 0)
            {
                defaultframe = new Rectangle(0, 0, 40, 56);
                hairframe = new Rectangle(0, 0, 40, 56);
                frameMultiplier = 6;
            }
            else if (projectile.velocity.X < -.8 || projectile.velocity.X > .8)
            {
                frameCounter += (int)System.Math.Abs(projectile.velocity.X);
                frameCounter++;
            }
            if (projectile.oldVelocity.Y != 0)
            {
                defaultframe = new Rectangle(0, 280, 40, 56);
                hairframe = new Rectangle(0, 0, 40, 56);
            }
            if (projectile.oldVelocity.Y == 0)
                defaultframe = new Rectangle(0, 0, 40, 56);
            if (projectile.velocity.X != 0)
            {
                frameCounter++;
                if (frameCounter > 6)
                {
                    frameMultiplier++;
                    frameCounter = 0;
                }
                if (frameMultiplier == 6 && projectile.oldVelocity.Y == 0)
                {
                    defaultframe = new Rectangle(0, 1064, 40, 56);
                    hairframe = new Rectangle(0, 728, 40, 56);
                }
                else if (frameMultiplier != 6 && projectile.oldVelocity.Y == 0)
                {
                    defaultframe = new Rectangle(0, 56 * frameMultiplier, 40, 56);
                    hairframe = new Rectangle(0, 56 * (frameMultiplier - 6), 40, 56);
                }
                if (frameMultiplier >= 19 && frameCounter >= 5)
                    frameMultiplier = 6;
                if (distanceToIdlePosition < 96 && (modPlayer.projSlippy || modPlayer.projSlippy2 || modPlayer.projWindPushed))
                {
                    defaultframe = new Rectangle(0, 0, 40, 56);
                    hairframe = new Rectangle(0, 0, 40, 56);
                }
            }
            #endregion
        }

        public override bool PreDraw(SpriteBatch notSpriteBatch, Color lightColor)
        {
            Player player = Main.player[projectile.owner];
            Vector2 drawPos = projectile.Top - Main.screenPosition;
            int skinVariant = player.skinVariant;
            Color lighting = Lighting.GetColor((int)projectile.Center.X / 16, (int)projectile.Center.Y / 16);
            Color eyeColor = Lighting.GetColor((int)projectile.Center.X / 16, (int)projectile.Center.Y / 16, player.eyeColor);
            Color hairColor = lighting.MultiplyRGBA(player.hairColor);
            Color eyeWhites = Lighting.GetColor((int)projectile.Center.X / 16, (int)projectile.Center.Y / 16, Color.White);
            Color skinColor = Lighting.GetColor((int)projectile.Center.X / 16, (int)projectile.Center.Y / 16, player.skinColor);
            Color shirtColor = Lighting.GetColor((int)projectile.Center.X / 16, (int)projectile.Center.Y / 16, player.shirtColor);
            Color underShirtColor = Lighting.GetColor((int)projectile.Center.X / 16, (int)projectile.Center.Y / 16, player.underShirtColor);
            Color pantsColor = Lighting.GetColor((int)projectile.Center.X / 16, (int)projectile.Center.Y / 16, player.pantsColor);
            Color shoeColor = Lighting.GetColor((int)projectile.Center.X / 16, (int)projectile.Center.Y / 16, player.shoeColor);
            Vector2 balloonOffset = new Vector2(28, 18);
            if (player.back > 0 && player.back < Main.accBackTexture.Length && Main.accBackLoaded[player.back])
                notSpriteBatch.Draw(Main.accBackTexture[player.back], drawPos, defaultframe, lighting, 0f, hairOffset, 1f, spriteDirection, 1f);
            if (player.wings > 0 && player.wings < Main.wingsTexture.Length && Main.wingsLoaded[player.wings])
                notSpriteBatch.Draw(Main.wingsTexture[player.wings], drawPos, defaultframe, lighting, 0f, hairOffset, 1f, spriteDirection, 1f);
            if (player.balloon > 0 && player.balloon < Main.accBalloonTexture.Length)
               notSpriteBatch.Draw(Main.accBalloonTexture[player.balloon], drawPos, balloonframe, lighting, 0f, balloonOffset, 1f, spriteDirection, 1f);
            notSpriteBatch.Draw(Main.playerTextures[0, 3], drawPos, defaultframe, skinColor, 0f, drawCenter, 1f, spriteDirection, 1f);
            notSpriteBatch.Draw(Main.playerTextures[0, 0], drawPos, defaultframe, skinColor, 0f, drawCenter, 1f, spriteDirection, 1f);
            notSpriteBatch.Draw(Main.playerTextures[0, 1], drawPos, defaultframe, eyeWhites, 0f, drawCenter, 1f, spriteDirection, 1f);
            notSpriteBatch.Draw(Main.playerTextures[0, 2], drawPos, defaultframe, eyeColor, 0f, drawCenter, 1f, spriteDirection, 1f);
            notSpriteBatch.Draw(Main.playerHairTexture[player.hair], drawPos, hairframe, hairColor, 0f, hairOffset, 1f, spriteDirection, 1f);
            if (player.face > 0 && player.face < Main.accFaceTexture.Length && Main.accFaceLoaded[player.face])
                notSpriteBatch.Draw(Main.accFaceTexture[player.face], drawPos, defaultframe, lighting, 0f, hairOffset, 1f, spriteDirection, 1f);
            if (skinVariant == 4 || skinVariant == 9)
                notSpriteBatch.Draw(Main.playerTextures[4, 10], drawPos, defaultframe, skinColor, 0f, drawCenter, 1f, spriteDirection, 1f);
            if (skinVariant == 8)
                notSpriteBatch.Draw(Main.playerTextures[0, 10], drawPos, defaultframe, skinColor, 0f, drawCenter, 1f, spriteDirection, 1f);
            notSpriteBatch.Draw(Main.playerTextures[skinVariant, 4], drawPos, defaultframe, underShirtColor, 0f, drawCenter, 1f, spriteDirection, 1f);
            notSpriteBatch.Draw(Main.playerTextures[skinVariant, 6], drawPos, defaultframe, shirtColor, 0f, drawCenter, 1f, spriteDirection, 1f);
            notSpriteBatch.Draw(Main.playerTextures[0, 7], drawPos, defaultframe, skinColor, 0f, drawCenter, 1f, spriteDirection, 1f);
            notSpriteBatch.Draw(Main.playerTextures[skinVariant, 8], drawPos, defaultframe, underShirtColor, 0f, drawCenter, 1f, spriteDirection, 1f);
            if (player.shield > 0 && player.shield < Main.accShieldTexture.Length && Main.accShieldLoaded[player.shield])
                notSpriteBatch.Draw(Main.accShieldTexture[player.shield], drawPos, defaultframe, lighting, 0f, hairOffset, 1f, spriteDirection, 1f);
            notSpriteBatch.Draw(Main.playerTextures[skinVariant, 11], drawPos, defaultframe, pantsColor, 0f, drawCenter, 1f, spriteDirection, 1f);
            notSpriteBatch.Draw(Main.playerTextures[skinVariant, 12], drawPos, defaultframe, shoeColor, 0f, drawCenter, 1f, spriteDirection, 1f);
            if (player.shoe > 0 && player.shoe < Main.accShoesTexture.Length && Main.accShoesLoaded[player.shoe])
                notSpriteBatch.Draw(Main.accShoesTexture[player.shoe], drawPos, defaultframe, lighting, 0f, hairOffset, 1f, spriteDirection, 1f);
            if (player.handoff > 0 && player.handoff < Main.accHandsOffTexture.Length && Main.accHandsOffLoaded[player.handoff])
                notSpriteBatch.Draw(Main.accHandsOffTexture[player.handoff], drawPos, defaultframe, lighting, 0f, hairOffset, 1f, spriteDirection, 1f);
            if (player.neck > 0 && player.neck < Main.accNeckTexture.Length && Main.accNeckLoaded[player.handoff])
                notSpriteBatch.Draw(Main.accNeckTexture[player.neck], drawPos, defaultframe, lighting, 0f, hairOffset, 1f, spriteDirection, 1f);
            if (player.waist > 0 && player.waist < Main.accWaistTexture.Length && Main.accWaistLoaded[player.waist])
                notSpriteBatch.Draw(Main.accWaistTexture[player.waist], drawPos, defaultframe, lighting, 0f, hairOffset, 1f, spriteDirection, 1f);
            if (skinVariant == 2 || skinVariant == 3 || skinVariant == 4 || skinVariant == 6 || skinVariant == 7 || skinVariant == 8 || skinVariant == 9)
            {
                notSpriteBatch.Draw(Main.playerTextures[skinVariant, 13], drawPos, defaultframe, shirtColor, 0f, drawCenter, 1f, spriteDirection, 1f);
                if (skinVariant == 3 || skinVariant == 7 || skinVariant == 8)
                    notSpriteBatch.Draw(Main.playerTextures[skinVariant, 14], drawPos, defaultframe, shirtColor, 0f, drawCenter, 1f, spriteDirection, 1f);
            }
            if (player.handon > 0 && player.handon < Main.accHandsOnTexture.Length && Main.accHandsOnLoaded[player.handon])
                notSpriteBatch.Draw(Main.accHandsOnTexture[player.handon], drawPos, defaultframe, lighting, 0f, hairOffset, 1f, spriteDirection, 1f);
            if (player.front > 0 && player.front < Main.accHandsOnTexture.Length && Main.accFrontLoaded[player.front])
                notSpriteBatch.Draw(Main.accFrontTexture[player.front], drawPos, defaultframe, lighting, 0f, hairOffset, 1f, spriteDirection, 1f);
            return true;
        }
    }
}