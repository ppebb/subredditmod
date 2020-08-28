using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using rterrariamod.Items;
using rterrariamod.Items.Armor;
using rterrariamod.Items.Tools;
using rterrariamod.Items.Accessories;
using rterrariamod.Items.PocketCrafters;
using static Terraria.ModLoader.ModContent;

namespace rterrariamod
{
    public static class Recipes
    {
        public static void AddRecipes()
        {
            Player player = Main.player[Main.myPlayer];

            //Accessories

            ModRecipe recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.PygmyNecklace, 1);
            recipe.AddIngredient(ItemID.HerculesBeetle, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemType<BeetleNecklace>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.PapyrusScarab, 1);
            recipe.AddIngredient(ItemID.SummonerEmblem, 1);
            recipe.AddIngredient(ItemType<BeetleNecklace>(), 1);
            recipe.AddIngredient(ItemType<SkeletonSkull>(), 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemType<SummonersMask>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.Goggles, 1);
            recipe.AddIngredient(ItemID.NightOwlPotion, 15);
            recipe.AddTile(TileID.Tables);
            recipe.AddTile(TileID.Chairs);
            recipe.SetResult(ItemType<NightVisionGoggles>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.HandWarmer, 1);
            recipe.AddIngredient(ItemID.PocketMirror, 1);
            recipe.AddIngredient(ItemType<NightVisionGoggles>(), 1);
            recipe.AddIngredient(ItemType<Antidote>(), 1);
            recipe.AddIngredient(ItemID.AnkhShield, 1);
            recipe.AddIngredient(ItemID.CellPhone, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemType<Nokia3310>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemType<BeehiveMiniature>(), 1);
            recipe.AddIngredient(ItemType<SpiderEggSack>(), 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemType<ArthropodInsignia>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.DestroyerEmblem, 1);
            recipe.AddIngredient(ItemType<ArthropodInsignia>(), 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemType<JungleIdol>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.Amethyst, 1);
            recipe.AddIngredient(ItemID.Topaz, 1);
            recipe.AddIngredient(ItemID.Sapphire, 1);
            recipe.AddIngredient(ItemID.Ruby, 1);
            recipe.AddIngredient(ItemID.Emerald, 1);
            recipe.AddIngredient(ItemID.Diamond, 1);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemType<SparklePin>());

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.SummonerEmblem, 1);
            recipe.AddIngredient(ItemID.TitanGlove, 1);
            recipe.AddRecipeGroup("rterrariamod:String", 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemType<CowboyGlove>());
            recipe.AddRecipe();

            //Armor

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddRecipeGroup("rterrariamod:EvilHelmets", 1);
            recipe.AddIngredient(ItemID.JungleHat, 1);
            recipe.AddIngredient(ItemID.MoltenHelmet, 1);
            recipe.AddIngredient(ItemID.NecroHelmet, 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemType<NightsHelmet>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddRecipeGroup("rterrariamod:EvilScalemail", 1);
            recipe.AddIngredient(ItemID.JungleShirt, 1);
            recipe.AddIngredient(ItemID.MoltenBreastplate, 1);
            recipe.AddIngredient(ItemID.NecroBreastplate, 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemType<NightsScalemail>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddRecipeGroup("rterrariamod:EvilGreaves", 1);
            recipe.AddIngredient(ItemID.JunglePants, 1);
            recipe.AddIngredient(ItemID.MoltenGreaves, 1);
            recipe.AddIngredient(ItemID.NecroGreaves, 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemType<NightsGreaves>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemType<NightsHelmet>(), 1);
            recipe.AddIngredient(ItemType<BrokenHeroBar>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemType<TrueNightsHelmet>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemType<NightsScalemail>(), 1);
            recipe.AddIngredient(ItemType<BrokenHeroBar>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemType<TrueNightsScalemail>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemType<NightsGreaves>(), 1);
            recipe.AddIngredient(ItemType<BrokenHeroBar>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemType<TrueNightsGreaves>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.HallowedHelmet, 1);
            recipe.AddIngredient(ItemType<BrokenHeroBar>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemType<TrueHallowedHelmet>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.HallowedMask, 1);
            recipe.AddIngredient(ItemType<BrokenHeroBar>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemType<TrueHallowedMask>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.HallowedHeadgear, 1);
            recipe.AddIngredient(ItemType<BrokenHeroBar>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemType<TrueHallowedHeadgear>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.HallowedPlateMail, 1);
            recipe.AddIngredient(ItemType<BrokenHeroBar>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemType<TrueHallowedPlateMail>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.HallowedGreaves, 1);
            recipe.AddIngredient(ItemType<BrokenHeroBar>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemType<TrueHallowedGreaves>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemType<TrueNightsHelmet>(), 1);
            recipe.AddRecipeGroup("rterrariamod:TrueHallowedHeadpiece");
            recipe.AddIngredient(ItemType<BrokenHeroBar>(), 1);
            recipe.AddIngredient(ItemType<TerraFragment>(), 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemType<TerraHelmet>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemType<TrueNightsScalemail>(), 1);
            recipe.AddIngredient(ItemType<TrueHallowedPlateMail>(), 1);
            recipe.AddIngredient(ItemType<BrokenHeroBar>(), 1);
            recipe.AddIngredient(ItemType<TerraFragment>(), 4);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemType<TerraBreastplate>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemType<TrueNightsGreaves>(), 1);
            recipe.AddIngredient(ItemType<TrueHallowedGreaves>(), 1);
            recipe.AddIngredient(ItemType<BrokenHeroBar>(), 1);
            recipe.AddIngredient(ItemType<TerraFragment>(), 2);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemType<TerraBoots>());
            recipe.AddRecipe();

            //Items

            if (player.ZoneHoly)
            {
                recipe = new ModRecipe(GetInstance<RTerrariaMod>());
                recipe.AddIngredient(ItemID.Pwnhammer, 1);
                recipe.AddIngredient(ItemID.PurificationPowder, 20);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ItemType<PurifiedHammer>());
                recipe.AddRecipe();
            }

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.StoneBlock, 20);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemType<MortarAndPestle>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.BeeWax, 3);
            recipe.needHoney = true;
            recipe.SetResult(ItemType<HoneyGlue>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.WorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.BorealWoodWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketBorealWoodWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.EbonwoodWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketEbonwoodWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.ShadewoodWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketShadewoodWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.RichMahoganyWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketRichMahoganyWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.PalmWoodWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketPalmWoodWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.PearlwoodWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketPearlWoodWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.LivingWoodWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketLivingWoodWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.CactusWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketCactusWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.WorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.FleshWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketFleshWorkbench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.MushroomWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketMushroomWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.SlimeWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketSlimeWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.BoneWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketBoneWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.LihzahrdWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketLihzahrdWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.BlueDungeonWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketBlueDungeonWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.GreenDungeonWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketGreenDungeonWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.PinkDungeonWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketPinkDungeonWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.ObsidianWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketObsidianWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.GothicWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketGothicWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.PumpkinWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketPumpkinWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.SpookyWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketSpookyWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.DynastyWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketDynastyWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.HoneyWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketHoneyWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.FrozenWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketFrozenWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.SteampunkWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketSteampunkWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.SkywareWorkbench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketSkywareWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.GlassWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketGlassWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.MartianWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketMartianWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.MeteoriteWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketMeteoriteWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.GraniteWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketGraniteWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.MarbleWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketMarbleWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.CrystalWorkbench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketCrystalWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.WorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.GoldenWorkbench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketGoldenWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.Furnace, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketFurnace>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.IronAnvil, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketAnvil>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.LeadAnvil, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketLeadAnvil>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.Hellforge, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketHellforge>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.Loom, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketLoom>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.Sawmill, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketSawmill>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.GlassKiln, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketGlassKiln>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.AlchemyTable, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketAlchemyTable>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.CookingPot, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketCookingPot>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.Cauldron, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketCauldron>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.TinkerersWorkshop, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketTinkerersWorkshop>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.ImbuingStation, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketImbuingStation>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.DyeVat, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketDyeVat>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.HeavyWorkBench, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketHeavyWorkBench>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.MythrilAnvil, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketMythrilAnvil>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.OrichalcumAnvil, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketOrichalcumAnvil>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.AdamantiteForge, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketAdamantiteForge>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.TitaniumForge, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketTitaniumForge>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.Bookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.BlueDungeonBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketBlueDungeonBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.GreenDungeonBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketGreenDungeonBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.PinkDungeonBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketPinkDungeonBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.ObsidianBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketObsidianBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.GothicBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketGothicBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.CactusBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketCactusBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.EbonwoodBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketEbonwoodBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.FleshBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketFleshBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.HoneyBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketHoneyBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.SteampunkBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketSteampunkBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.GlassBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketGlassBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.RichMahoganyBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketRichMahoganyBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.PearlwoodBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketPearlWoodBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.SpookyBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketSpookyBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.SkywareBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketSkywareBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.LihzahrdBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketLihzahrdBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.FrozenBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketFrozenBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.LivingWoodBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketLivingWoodBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.ShadewoodBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketShadewoodBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.GoldenBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketGoldenBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.BoneBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketBoneBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.DynastyBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketDynastyBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.PalmWoodBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketPalmWoodBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.MushroomBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketMushroomBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.BorealWoodBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketBorealWoodBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.SlimeBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketSlimeBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.PumpkinBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketPumpkinBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.MartianHolobookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketMartianHolobookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.MeteoriteBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketMeteoriteBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.GraniteBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketGraniteBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.MarbleBookcase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketMarbleBookcase>());
            recipe.AddRecipe();

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemID.CrystalBookCase, 1);
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketCrystalBookcase>());
            recipe.AddRecipe();

            if (WorldGen.crimson)
            {
                recipe = new ModRecipe(GetInstance<RTerrariaMod>());
                recipe.AddIngredient(ItemType<HoneyGlue>(), 7);
                recipe.AddIngredient(ItemType<CrimsonBits>(), 13);
                recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
                recipe.AddTile(TileID.HeavyWorkBench);
                recipe.SetResult(ItemType<PocketCrimsonAltar>());
                recipe.AddRecipe();
            }
            else
            {
                recipe = new ModRecipe(GetInstance<RTerrariaMod>());
                recipe.AddIngredient(ItemType<HoneyGlue>(), 7);
                recipe.AddIngredient(ItemType<CorruptBits>(), 13);
                recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
                recipe.AddTile(TileID.HeavyWorkBench);
                recipe.SetResult(ItemType<PocketDemonAltar>());
                recipe.AddRecipe();
            }

            recipe = new ModRecipe(GetInstance<RTerrariaMod>());
            recipe.AddIngredient(ItemType<CrystalPowder>(), 3);
            recipe.AddIngredient(ItemID.Autohammer, 1);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.SetResult(ItemType<PocketAutohammer>());
            recipe.AddRecipe();
        }
    }
}