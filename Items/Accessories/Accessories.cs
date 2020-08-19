using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace rterrariamod.Items.Accessories
{

    public abstract class OverarchingAccessory : ModItem
    {
        public override bool CanEquipAccessory(Player player, int slot)
        {
            if (slot < 10)
            {
                int index = FindDifferentEquippedOverarchingAccessory().index;
                if (index != -1)
                {
                    return slot == index;
                }
            }
            return base.CanEquipAccessory(player, slot);
        }

        public override bool CanRightClick()
        {
            int maxAccessoryIndex = 5 + Main.LocalPlayer.extraAccessorySlots;
            for (int i = 13; i < 13 + maxAccessoryIndex; i++)
            {
                if (Main.LocalPlayer.armor[i].type == item.type) return false;
            }

            if (FindDifferentEquippedOverarchingAccessory().accessory != null)
            {
                return true;
            }
            return base.CanRightClick();
        }

        public override void RightClick(Player player)
        {
            var (index, accessory) = FindDifferentEquippedOverarchingAccessory();
            if (accessory != null)
            {
                Main.LocalPlayer.QuickSpawnClonedItem(accessory);
                Main.LocalPlayer.armor[index] = item.Clone();
            }

        }

        protected (int index, Item accessory) FindDifferentEquippedOverarchingAccessory()
        {
            int maxAccessoryIndex = 5 + Main.LocalPlayer.extraAccessorySlots;
            for (int i = 3; i < 3 + maxAccessoryIndex; i++)
            {
                Item otherAccessory = Main.LocalPlayer.armor[i];
                if (!otherAccessory.IsAir &&
                    !item.IsTheSameAs(otherAccessory) &&
                    otherAccessory.modItem is OverarchingAccessory)
                {
                    return (i, otherAccessory);
                }
            }
            return (-1, null);
        }
    }
    public class BeetleNecklace : OverarchingAccessory
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases the damage of your minions by 15%\nIncreases the knockback of your minions\nIncreases your max number of minions by 1");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 36;
            item.accessory = true;
            item.value = Item.sellPrice(gold: 12);
            item.rare = ItemRarityID.Lime;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.minionDamage += 0.15f;
            player.minionKB += 0.5f;
            player.maxMinions += 1;
        }
    }

    public class SummonersMask : OverarchingAccessory
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Summoner's Mask");
            Tooltip.SetDefault("Increases the damage of your minions by 45%\nIncreases the knockback of your minions\nIncreases your max number of minions by 2");
        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 28;
            item.accessory = true;
            item.value = Item.sellPrice(gold: 17);
            item.rare = ItemRarityID.Lime;
            item.defense = 4;
        }

        public override void UpdateAccessory(Player player, bool hidevisual)
        {
            player.minionDamage += 0.45f;
            player.minionKB += 0.5f;
            player.maxMinions += 2;
            ModConfig config = ModContent.GetInstance<rTerrariaModConfig>();
            if (config == null)
                return;
            if (ModContent.GetInstance<rTerrariaModConfig>().skeletonImmunityConfig)
            {
                player.npcTypeNoAggro[NPCID.Skeleton] = true;
                player.npcTypeNoAggro[NPCID.HeadacheSkeleton] = true;
                player.npcTypeNoAggro[NPCID.MisassembledSkeleton] = true;
                player.npcTypeNoAggro[NPCID.PantlessSkeleton] = true;
                player.npcTypeNoAggro[NPCID.ArmoredSkeleton] = true;
                player.npcTypeNoAggro[NPCID.UndeadMiner] = true;
                player.npcTypeNoAggro[NPCID.AngryBones] = true;
                player.npcTypeNoAggro[NPCID.AngryBonesBig] = true;
                player.npcTypeNoAggro[NPCID.AngryBonesBigHelmet] = true;
                player.npcTypeNoAggro[NPCID.AngryBonesBigMuscle] = true;
                player.npcTypeNoAggro[NPCID.BoneThrowingSkeleton] = true;
                player.npcTypeNoAggro[NPCID.BoneThrowingSkeleton2] = true;
                player.npcTypeNoAggro[NPCID.BoneThrowingSkeleton3] = true;
                player.npcTypeNoAggro[NPCID.BoneThrowingSkeleton4] = true;
            }
        }
    }

    public class Nokia3310 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nokia 3310");
            Tooltip.SetDefault("Displays everything\nAllows you to return home at will\nGrants immunity to knockback and fire blocks\nGrants immunity to most debuffs\nImmunities will only work when equipped\n'Indestructable'");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 32;
            item.accessory = true;
            item.value = Item.sellPrice(gold: 20);
            item.rare = ItemRarityID.Lime;
            item.defense = 5;
            item.useTurn = true;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.useTime = 90;
            item.UseSound = SoundID.Item6;
            item.useAnimation = 90;
        }

        public override void UseStyle(Player player)
        {
            if (Main.rand.Next(2) == 0)
            {
                Dust.NewDust(player.position, player.width, player.height, 15, 0f, 0f, 150, default, 1.1f);
            }
            if (player.itemTime == 0)
            {
                player.itemTime = (int)(item.useTime / PlayerHooks.TotalUseTimeMultiplier(player, item));
            }
            else if (player.itemTime == (int)(item.useTime / PlayerHooks.TotalUseTimeMultiplier(player, item)) / 2)
            {
                for (int num325 = 0; num325 < 70; num325++)
                {
                    Dust.NewDust(player.position, player.width, player.height, 15, player.velocity.X * 0.5f, player.velocity.Y * 0.5f, 150, default, 1.5f);
                }
                player.grappling[0] = -1;
                player.grapCount = 0;
                for (int p = 0; p < 1000; p++)
                {
                    if (Main.projectile[p].active && Main.projectile[p].owner == player.whoAmI && Main.projectile[p].aiStyle == 7)
                    {
                        Main.projectile[p].Kill();
                    }
                }
                player.Spawn();
                for (int num327 = 0; num327 < 70; num327++)
                {
                    Dust.NewDust(player.position, player.width, player.height, 15, 0f, 0f, 150, default, 1.5f);
                }
            }
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.accWatch = 3;
            player.accDepthMeter = 1;
            player.accCompass = 1;
            player.accFishFinder = true;
            player.accWeatherRadio = true;
            player.accCalendar = true;
            player.accThirdEye = true;
            player.accJarOfSouls = true;
            player.accCritterGuide = true;
            player.accStopwatch = true;
            player.accOreFinder = true;
            player.accDreamCatcher = true;
            player.noKnockback = true;
            player.fireWalk = true;
            player.buffImmune[46] = true; // Chilled
            player.buffImmune[33] = true; // Weak
            player.buffImmune[36] = true; // Broken Armor
            player.buffImmune[30] = true; // Bleeding
            player.buffImmune[20] = true; // Poisoned
            player.buffImmune[32] = true; // Slow
            player.buffImmune[31] = true; // Confused
            player.buffImmune[35] = true; // Silenced
            player.buffImmune[23] = true; // Cursed
            player.buffImmune[22] = true; // Darkness
            player.buffImmune[156] = true;// Stoned
            player.buffImmune[47] = true; // Frozen
            player.buffImmune[70] = true; // Venom
            player.buffImmune[80] = true; // Blackout
            player.buffImmune[80] = true; // Blackout
            player.GetModPlayer<Rterrariaplayer>().NokiaRecall = true;
        }

        public override void UpdateInventory(Player player)
        {
            player.accWatch = 3;
            player.accDepthMeter = 1;
            player.accCompass = 1;
            player.accFishFinder = true;
            player.accWeatherRadio = true;
            player.accCalendar = true;
            player.accThirdEye = true;
            player.accJarOfSouls = true;
            player.accCritterGuide = true;
            player.accStopwatch = true;
            player.accOreFinder = true;
            player.accDreamCatcher = true;
            player.GetModPlayer<Rterrariaplayer>().NokiaRecall = true;
        }
    }

    [AutoloadEquip(EquipType.Face)]
    public class NightVisionGoggles : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Provides immunity to blackout and darkness");
        }

        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 8;
            item.accessory = true;
            item.value = Item.sellPrice(silver: 35);
            item.rare = ItemRarityID.Blue;
            item.defense = 1;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.buffImmune[22] = true; // Darkness
            player.buffImmune[80] = true; // Blackout
        }
    }

    public class Antidote : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Provides immunity to poison and venom");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.accessory = true;
            item.value = Item.sellPrice(gold: 5);
            item.rare = ItemRarityID.Orange;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.buffImmune[20] = true; // Poisoned
            player.buffImmune[70] = true; // Venom
        }
    }
    public class SkeletonSkull : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 22;
            item.accessory = true;
            item.value = Item.sellPrice(silver: 75);
            item.rare = ItemRarityID.Green;
            item.defense = 4;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            ModConfig config = ModContent.GetInstance<rTerrariaModConfig>();
            if (config == null)
                return;
            if (ModContent.GetInstance<rTerrariaModConfig>().skeletonImmunityConfig)
            {
                player.npcTypeNoAggro[NPCID.Skeleton] = true;
                player.npcTypeNoAggro[NPCID.HeadacheSkeleton] = true;
                player.npcTypeNoAggro[NPCID.MisassembledSkeleton] = true;
                player.npcTypeNoAggro[NPCID.PantlessSkeleton] = true;
                player.npcTypeNoAggro[NPCID.ArmoredSkeleton] = true;
                player.npcTypeNoAggro[NPCID.UndeadMiner] = true;
                player.npcTypeNoAggro[NPCID.AngryBones] = true;
                player.npcTypeNoAggro[NPCID.AngryBonesBig] = true;
                player.npcTypeNoAggro[NPCID.AngryBonesBigHelmet] = true;
                player.npcTypeNoAggro[NPCID.AngryBonesBigMuscle] = true;
                player.npcTypeNoAggro[NPCID.BoneThrowingSkeleton] = true;
                player.npcTypeNoAggro[NPCID.BoneThrowingSkeleton2] = true;
                player.npcTypeNoAggro[NPCID.BoneThrowingSkeleton3] = true;
                player.npcTypeNoAggro[NPCID.BoneThrowingSkeleton4] = true;
            }
        }
    }

    public class BeehiveMiniature : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Bees are stored in the hive\nIncreases your max number of minions by 1\nMinions release bees after striking a foe");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.accessory = true;
            item.value = Item.sellPrice(silver: 75);
            item.rare = ItemRarityID.Orange;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.maxMinions += 1;
            player.GetModPlayer<Rterrariaplayer>().BeeHiveMini = true;
        }
    }

    public class SpiderEggSack : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("You feel all itchy\nIncreases minion damage by 5%");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.accessory = true;
            item.value = Item.sellPrice(silver: 550);
            item.rare = ItemRarityID.LightRed;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.minionDamage += .05f;
        }

    }

    public class ArthropodInsignia : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases your max number of minions by 1\nIncreases minion damage by 5%\nMinions release a swarm of bees after striking a foe");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.accessory = true;
            item.value = Item.sellPrice(gold: 7);
            item.rare = ItemRarityID.LightRed;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.maxMinions += 1;
            player.minionDamage += .05f;
            player.GetModPlayer<Rterrariaplayer>().BeeHiveMini = true;
        }
    }

    public class JungleIdol : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases your max number of minions by 2\nIncreases minion damage by 15%\nMinions release a swarm of moths after striking a foe");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.accessory = true;
            item.value = Item.sellPrice(gold: 12);
            item.rare = ItemRarityID.Lime;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.maxMinions += 2;
            player.minionDamage += .15f;
            player.GetModPlayer<Rterrariaplayer>().IdolMoth = true;
        }
    }

    public class SparklePin : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases minion damage by 10%");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.accessory = true;
            item.value = Item.sellPrice(gold: 2);
            item.rare = ItemRarityID.Blue;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.minionDamage += .1f;
        }
    }

    public class OvergrownSpore : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases your max number of minions by 1");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 26;
            item.accessory = true;
            item.value = Item.sellPrice(gold: 4);
            item.rare = ItemRarityID.Orange;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.maxMinions += 1;
        }
    }

    public class RoyalDefense : ModItem
    {
        public int defencecount;
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Adds 1 defense for every minion summoned\n'It's gross and slimey'");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 26;
            item.accessory = true;
            item.value = Item.sellPrice(gold: 3);
            item.rare = ItemRarityID.Green;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            var defencecount = player.numMinions;
            player.statDefense += defencecount;
        }
    }

    public class CowboyGlove : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases minion damage by 20%\nWill do stuff with whips once tMod 1.4 releases");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 28;
            item.accessory = true;
            item.value = Item.sellPrice(gold: 2, silver: 50);
            item.rare = ItemRarityID.LightRed;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.minionDamage += .2f;
        }
    }
}