using Terraria;
using Terraria.ID;
using Terraria.GameInput;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using rterrariamod.Projectiles;
using rterrariamod.Items.PocketCrafters;

namespace rterrariamod
{
    public class Rterrariaplayer : ModPlayer
    {
        // TODO: Hammer radial menu
        public int beespawncount;
        public int mothspawncount;
        public int delay;
        public int delay2;
        public int beedelay;
        public int mothdelay;
		public int manaFruits;
        public const int maxManaFruits = 10;
        public bool startcounting;
        public bool HeartLocketSummon;
        public bool NokiaRecall = false;
        public bool BeeHiveMini = false;
        public bool IdolMoth = false;
        public bool projSlippy = false;
        public bool projSlippy2 = false;
        public bool projWindPushed = false;
        public bool lRHoney = false;
        public float projGravity = 0.4f;
		public float projJumpSpeed = 5.01f;
		public float projMaxRunSpeed = 3f;
        public float projRunAcceleration = 0.08f;
		public float projRunSlowdown = 0.2f;
        public float projAccRunSpeed;
        public float projMaxFallSpeed = 10f;

        public override void ResetEffects()
        {
            HeartLocketSummon = false;
            NokiaRecall = false;
            BeeHiveMini = false;
            IdolMoth = false;
            player.statManaMax2 += manaFruits * 10;
            projJumpSpeed = 8.51f;
            projMaxRunSpeed = 3f;
            projRunAcceleration = 0.08f;
            projRunSlowdown = 0.2f;
            projAccRunSpeed = projMaxRunSpeed;
            projMaxFallSpeed = 10f;
            projGravity = 0.4f;
            projSlippy = false;
            projSlippy2 = false;
            projWindPushed = false;
            lRHoney = false;
        }

        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer)
        {
            ModPacket packet = mod.GetPacket();
            packet.Write((byte)player.whoAmI);
            packet.Write(manaFruits);
            packet.Send(toWho, fromWho);
        }

        public override TagCompound Save()
        {
            return new TagCompound
            {
                {"manaFruits", manaFruits}
            };
        }
        public override void Load(TagCompound tag)
        {
            manaFruits = tag.GetInt("manaFruits");
        }
        public override void PreUpdate()
        {
            beedelay++;
            mothdelay++;
            //if (player.HasItem(ModContent.ItemType<PocketCrystalBall>()))
            //{
            //    player.AddBuff(BuffID.Clairvoyance, 2);
            //}
            if (startcounting)
            {
                delay2++;
            }
            if (delay2 >= 45)
            {
                player.grappling[0] = -1;
                player.grapCount = 0;
                for (int p = 0; p < 1000; p++)
                {
                    if (Main.projectile[p].active && Main.projectile[p].owner == player.whoAmI && Main.projectile[p].aiStyle == 7)
                    {
                        Main.projectile[p].Kill();
                    }
                }
                for (int num327 = 0; num327 < 70; num327++)
                {
                    Dust.NewDust(player.oldPosition, player.width, player.height, 15, 0f, 0f, 150, default, 1.5f);
                }
                player.Spawn();
                for (int num327 = 0; num327 < 70; num327++)
                {
                    Dust.NewDust(player.position, player.width, player.height, 15, 0f, 0f, 150, default, 1.5f);
                }
                for (int i = 0; i < player.inventory.Length; i++)
                {
                    Item item = player.inventory[i];

                    if (NokiaRecall || player.HasItem(ItemID.MagicMirror) || player.HasItem(ItemID.IceMirror) || player.HasItem(ItemID.CellPhone))
                        break;

                    if (item.type != ItemID.RecallPotion)
                        continue;

                    if (ItemLoader.ConsumeItem(item, player) && item.stack > 0)
                    {
                        item.stack--;
                    }
                }
                startcounting = false;
                delay2 = 0;
            }
            delay++;
        }

        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if (Rterrariamod.Nokia3310Recall.JustPressed && (NokiaRecall || player.HasItem(ItemID.RecallPotion) || player.HasItem(ItemID.MagicMirror) || player.HasItem(ItemID.IceMirror) || player.HasItem(ItemID.CellPhone)))
            {
                if (delay >= 90)
                {
                    Main.PlaySound(SoundID.Item6, (int)player.Center.X, (int)player.Center.Y);
                    for (int num325 = 0; num325 < 20; num325++)
                    {
                        Dust.NewDust(player.position, player.width, player.height, 15, player.velocity.X * 0.5f, player.velocity.Y * 0.5f, 150, default, 1.5f);
                    }
                    if (!startcounting)
                    {
                        startcounting = true;
                        delay2 = 0;
                    }
                }
                delay = 0;
            }
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if (proj.minion && BeeHiveMini && beedelay > 600)
            {
                if (beespawncount <= 8)
                {
                    Projectile.NewProjectile(proj.Center, proj.velocity, ProjectileID.Bee, 22, 0f, player.whoAmI);
                    beespawncount++;
                }
                else
                {
                    beespawncount = 0;
                    beedelay = 0;
                }
            }
            if (proj.minion && IdolMoth && mothdelay > 600)
            {
                if (mothspawncount <= 5)
                {
                    Projectile.NewProjectile(proj.Center, proj.velocity, ModContent.ProjectileType<Moth>(), 46, 0f, player.whoAmI);
                    mothspawncount++;
                }
                else
                {
                    mothspawncount = 0;
                    mothdelay = 0;
                }
            }
        }
    }
}