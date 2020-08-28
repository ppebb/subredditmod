using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rterrariamod.Items.PocketCrafters
{
    public abstract class PocketWorkBenches : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A work bench, but in your pocket'");
        }
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 12;
            item.value = Item.sellPrice(gold: 3);
            item.rare = ItemRarityID.LightRed;
        }
    }

    public class PocketWorkBench : PocketWorkBenches { }
    public class PocketBorealWoodWorkBench : PocketWorkBenches { }
    public class PocketEbonwoodWorkBench : PocketWorkBenches { }
    public class PocketShadewoodWorkBench : PocketWorkBenches { }
    public class PocketRichMahoganyWorkBench : PocketWorkBenches { }
    public class PocketPalmWoodWorkBench : PocketWorkBenches { }
    public class PocketPearlWoodWorkBench : PocketWorkBenches { }
    public class PocketLivingWoodWorkBench : PocketWorkBenches { }
    public class PocketCactusWorkBench : PocketWorkBenches { }
    public class PocketFleshWorkbench : PocketWorkBenches { }
    public class PocketMushroomWorkBench : PocketWorkBenches { }
    public class PocketSlimeWorkBench : PocketWorkBenches { }
    public class PocketBoneWorkBench : PocketWorkBenches { }
    public class PocketLihzahrdWorkBench : PocketWorkBenches { }
    public class PocketBlueDungeonWorkBench : PocketWorkBenches { }
    public class PocketGreenDungeonWorkBench : PocketWorkBenches { }
    public class PocketPinkDungeonWorkBench : PocketWorkBenches { }
    public class PocketObsidianWorkBench : PocketWorkBenches { }
    public class PocketGothicWorkBench : PocketWorkBenches { }
    public class PocketPumpkinWorkBench : PocketWorkBenches { }
    public class PocketSpookyWorkBench : PocketWorkBenches { }
    public class PocketDynastyWorkBench : PocketWorkBenches { }
    public class PocketHoneyWorkBench : PocketWorkBenches { }
    public class PocketFrozenWorkBench : PocketWorkBenches { }
    public class PocketSteampunkWorkBench : PocketWorkBenches { }
    public class PocketSkywareWorkBench : PocketWorkBenches { }
    public class PocketGlassWorkBench : PocketWorkBenches { }
    public class PocketMartianWorkBench : PocketWorkBenches { }
    public class PocketMeteoriteWorkBench : PocketWorkBenches { }
    public class PocketGraniteWorkBench : PocketWorkBenches { }
    public class PocketMarbleWorkBench : PocketWorkBenches { }
    public class PocketCrystalWorkBench : PocketWorkBenches { }
    public class PocketGoldenWorkBench : PocketWorkBenches { }

    public class PocketFurnace : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A furnace, but in your pocket'");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 18;
            item.value = Item.sellPrice(gold: 3);
            item.rare = ItemRarityID.LightRed;
        }
    }

    public abstract class PocketAnvils : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'An anvil, but in your pocket'");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 14;
            item.value = Item.sellPrice(gold: 3);
            item.rare = ItemRarityID.LightRed;
        }
    }
    public class PocketAnvil : PocketAnvils { }
    public class PocketLeadAnvil : PocketAnvils { }

    public class PocketHellforge : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A hellforge, but in your pocket'");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 18;
            item.value = Item.sellPrice(gold: 3);
            item.rare = ItemRarityID.LightRed;
        }
    }

    public class PocketLoom : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A loom, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 22;
            item.value = Item.sellPrice(gold: 3);
            item.rare = ItemRarityID.LightRed;
        }
    }

    public class PocketSawmill : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A sawmill, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 28;
            item.value = Item.sellPrice(gold: 3);
            item.rare = ItemRarityID.LightRed;
        }
    }

    public class PocketGlassKiln : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A glass kiln, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.value = Item.sellPrice(gold: 3);
            item.rare = ItemRarityID.LightRed;
        }
    }

    public class PocketAlchemyTable : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'An alchemy table, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 34;
            item.value = Item.sellPrice(gold: 5);
            item.rare = ItemRarityID.LightRed;
        }
    }

    public abstract class PocketCookingPots : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 3);
            item.rare = ItemRarityID.LightRed;
        }
    }
    public class PocketCookingPot : PocketCookingPots
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A cooking pot, but in your pocket'");
        }
    }
    public class PocketCauldron : PocketCookingPots
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A cauldron, but in your pocket'");
        }
    }

    public class PocketTinkerersWorkshop : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pocket Tinkerer's Workshop");
            Tooltip.SetDefault("'A tinkerer's workshop, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 5);
            item.rare = ItemRarityID.LightRed;
        }
    }

    public class PocketImbuingStation : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'An imbuing station, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 4);
            item.rare = ItemRarityID.LightRed;
        }
    }

    public class PocketDyeVat : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A dye vat, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 4);
            item.rare = ItemRarityID.LightRed;
        }
    }

    public class PocketHeavyWorkBench : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A heavy work bench, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 3);
            item.rare = ItemRarityID.LightRed;
        }
    }
    public class PocketCrimsonAltar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A crimson altar, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 10);
            item.rare = ItemRarityID.LightRed;
        }
    }
    public class PocketDemonAltar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A demon altar, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 10);
            item.rare = ItemRarityID.LightRed;
        }
    }

    public abstract class PocketHMAnvils : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 4);
            item.rare = ItemRarityID.Orange;
        }
    }
    public class PocketMythrilAnvil : PocketHMAnvils
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A mythril anvil, but in your pocket'");
        }
    }
    public class PocketOrichalcumAnvil : PocketHMAnvils
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'An orichalcum anvil, but in your pocket'");
        }
    }

    public abstract class PocketForges : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 4);
            item.rare = ItemRarityID.Orange;
        }
    }
    public class PocketAdamantiteForge : PocketForges
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'An adimantite forge, but in your pocket'");
        }
    }
    public class PocketTitaniumForge : PocketForges
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A titanium forge, but in your pocket'");
        }
    }

    public abstract class PocketBookcases : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A bookcase, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 3);
            item.rare = ItemRarityID.Red;
        }
    }
    public class PocketBookcase : PocketBookcases { }
    public class PocketBlueDungeonBookcase : PocketBookcases { }
    public class PocketGreenDungeonBookcase : PocketBookcases { }
    public class PocketPinkDungeonBookcase : PocketBookcases { }
    public class PocketObsidianBookcase : PocketBookcases { }
    public class PocketGothicBookcase : PocketBookcases { }
    public class PocketCactusBookcase : PocketBookcases { }
    public class PocketEbonwoodBookcase : PocketBookcases { }
    public class PocketFleshBookcase : PocketBookcases { }
    public class PocketHoneyBookcase : PocketBookcases { }
    public class PocketSteampunkBookcase : PocketBookcases { }
    public class PocketGlassBookcase : PocketBookcases { }
    public class PocketRichMahoganyBookcase : PocketBookcases { }
    public class PocketPearlWoodBookcase : PocketBookcases { }
    public class PocketSpookyBookcase : PocketBookcases { }
    public class PocketSkywareBookcase : PocketBookcases { }
    public class PocketLihzahrdBookcase : PocketBookcases { }
    public class PocketFrozenBookcase : PocketBookcases { }
    public class PocketLivingWoodBookcase : PocketBookcases { }
    public class PocketShadewoodBookcase : PocketBookcases { }
    public class PocketGoldenBookcase : PocketBookcases { }
    public class PocketBoneBookcase : PocketBookcases { }
    public class PocketDynastyBookcase : PocketBookcases { }
    public class PocketPalmWoodBookcase : PocketBookcases { }
    public class PocketMushroomBookcase : PocketBookcases { }
    public class PocketBorealWoodBookcase : PocketBookcases { }
    public class PocketSlimeBookcase : PocketBookcases { }
    public class PocketPumpkinBookcase : PocketBookcases { }
    public class PocketMartianHolobookcase : PocketBookcases { }
    public class PocketMeteoriteBookcase : PocketBookcases { }
    public class PocketGraniteBookcase : PocketBookcases { }
    public class PocketMarbleBookcase : PocketBookcases { }
    public class PocketCrystalBookcase : PocketBookcases { }

    public class PocketCrystalBall : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Gives clairvoyance buff\n'A crystal ball, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 5);
            item.rare = ItemRarityID.Orange;
        }
    }

    public class PocketAutohammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'An autohammer, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 25);
            item.rare = ItemRarityID.Orange;
        }
    }

    public class PocketAncientManipulator : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'An ancient manipulator, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 3);
            item.rare = ItemRarityID.Red;
        }
    }

    public class PocketKeg : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A keg, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 3);
            item.rare = ItemRarityID.LightRed;
        }
    }

    public class PocketBlendOMatic : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A blend-o-matic, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 5);
            item.rare = ItemRarityID.LightRed;
        }
    }

    public class PocketMeatGrinder : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'A meat grinder, but in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 5);
            item.rare = ItemRarityID.LightRed;
        }
    }

    public class PocketFurnitureStation : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'The power to craft most furniture, in your pocket'");
        }

        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.value = Item.sellPrice(gold: 20);
            item.rare = ItemRarityID.LightRed;
        }
    }
}