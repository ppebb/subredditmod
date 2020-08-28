using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using System;

namespace rterrariamod
{
	public class RTerrariaMod : Mod
	{
		public static ModHotKey Nokia3310Recall;

		public override void Load()
		{
			Nokia3310Recall = RegisterHotKey("Quick Recall (Works With Nokia 3310)", "Home");
			Player player = Main.player[Main.myPlayer];
			if (player.GetModPlayer<RTerrariaPlayer>().manaFruits > 1)
				On.Terraria.Main.DrawInterface_Resources_Mana += ManaFruitUI;


		}

        private void ManaFruitUI(On.Terraria.Main.orig_DrawInterface_Resources_Mana orig)
        {
            throw new NotImplementedException();
        }

        public override void Unload()
		{
			Nokia3310Recall = null;
		}

		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Any Evil Helmet", new int[]
			{
				ItemID.CrimsonHelmet,
				ItemID.ShadowHelmet,
				ItemID.AncientShadowHelmet
			});
			RecipeGroup.RegisterGroup("rterrariamod:EvilHelmets", group);

			RecipeGroup group1 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Any Evil Breastplate", new int[]
			{
				ItemID.CrimsonScalemail,
				ItemID.ShadowScalemail,
				ItemID.AncientShadowScalemail
			});
			RecipeGroup.RegisterGroup("rterrariamod:EvilScalemail", group1);

			RecipeGroup group2 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Any Evil Greaves", new int[]
			{
				ItemID.CrimsonGreaves,
				ItemID.ShadowGreaves,
				ItemID.AncientShadowGreaves
			});
			RecipeGroup.RegisterGroup("rterrariamod:EvilGreaves", group2);

			RecipeGroup group3 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Any True Hallowed Headpiece", new int[]
			{
				ModContent.ItemType<Items.Armor.TrueHallowedHelmet>(),
				ModContent.ItemType<Items.Armor.TrueHallowedMask>(),
				ModContent.ItemType<Items.Armor.TrueHallowedHeadgear>()
			});
			RecipeGroup.RegisterGroup("rterrariamod:TrueHallowedHeadpiece", group3);

			RecipeGroup group4 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Any String", new int[]
			{
				ItemID.BlackString,
				ItemID.BlueString,
				ItemID.BrownString,
				ItemID.CyanString,
				ItemID.GreenString,
				ItemID.LimeString,
				ItemID.OrangeString,
				ItemID.PinkString,
				ItemID.PurpleString,
				ItemID.RainbowString,
				ItemID.RedString,
				ItemID.SkyBlueString,
				ItemID.TealString,
				ItemID.VioletString,
				ItemID.WhiteString,
				ItemID.YellowString
			});
			RecipeGroup.RegisterGroup("rterrariamod:String", group4);

			RecipeGroup group5 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + "Any Mechanical Boss Soul", new int[]
			{
				ItemID.SoulofMight,
				ItemID.SoulofSight,
				ItemID.SoulofFright
			});
			RecipeGroup.RegisterGroup("rterrariamod:MechSoul", group5);
		}
		public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
			Player player = Main.player[Main.myPlayer];
			if (ModContent.GetInstance<rTerrariaModConfig>() == null)
				return;
			if (Main.dayTime && !player.ZoneBeach && !player.ZoneHoly && player.ZoneOverworldHeight && ModContent.GetInstance<rTerrariaModConfig>().whatconfig)
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/what");
				priority = MusicPriority.BiomeLow;
			}
        }

        public override void AddRecipes()
		{
			Recipes.AddRecipes();
		}
	}
}