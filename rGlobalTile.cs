using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using rterrariamod.Items;
using rterrariamod.Tiles;
using rterrariamod.Items.Tools;
using rterrariamod.Items.PocketCrafters;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;

namespace rterrariamod
{
    public class RGlobalTile : GlobalTile
    {
        public override void MouseOver(int i, int j, int type)
        {
            Tile mouseTile = Framing.GetTileSafely(Main.MouseWorld.ToTileCoordinates());
            if (mouseTile.type == ModContent.TileType<MortarAndPestleTile>())
            {
                Player player = Main.LocalPlayer;
                if (player.HeldItem.type == ItemID.CrystalBall)
                    Main.placementPreview = false;
            }
            else
                Main.placementPreview = true;
        }

        public override void KillTile(int i, int j, int type, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
            Tile tile = Main.tile[i, j];
            Player player = Main.LocalPlayer;
            if (type == TileID.JunglePlants)
            {
                if (tile.frameX == 18 * 8)
                {
                    if (Main.rand.NextFloat() < .04f)
                        Item.NewItem(i * 16, j * 16, 16, 16, ItemType<Items.Accessories.OvergrownSpore>());
                }
            }

            if (type == TileID.DemonAltar)
            {
                if (player.HeldItem.modItem is PurifiedHammer)
                {
                    if (!fail)
                    {
                        if (tile.frameX >= 54)
                            Item.NewItem(i * 16, j * 16, 16, 16, ItemType<CrimsonBits>(), (int)(Main.rand.Next(0, 3) / 2.5f));
                        else
                           Item.NewItem(i * 16, j * 16, 16, 16, ItemType<CorruptBits>(), (int)(Main.rand.Next(0, 3) / 2.5f));
                    }
                }
            }
        }

        public override int[] AdjTiles(int type)
        {
            Player player = Main.LocalPlayer;
            List<int> tiles = new List<int>();
            if (player.HasItem(ItemType<PocketWorkBenches>()))
                tiles.Add(TileID.WorkBenches);
            if (player.HasItem(ItemType<PocketFurnace>()))
                tiles.Add(TileID.Furnaces);
            if (player.HasItem(ItemType<PocketAnvils>()))
                tiles.Add(TileID.Anvils);
            if (player.HasItem(ItemType<PocketLoom>()))
                tiles.Add(TileID.Loom);
            if (player.HasItem(ItemType<PocketSawmill>()))
                tiles.Add(TileID.Sawmill);
            if (player.HasItem(ItemType<PocketGlassKiln>()))
                tiles.Add(TileID.GlassKiln);
            if (player.HasItem(ItemType<PocketHellforge>()))
                tiles.Add(TileID.Hellforge);
            if (player.HasItem(ItemType<PocketAlchemyTable>()))
                tiles.Add(TileID.AlchemyTable);
            if (player.HasItem(ItemType<PocketCookingPots>()))
                tiles.Add(TileID.CookingPots);
            if (player.HasItem(ItemType<PocketTinkerersWorkshop>()))
                tiles.Add(TileID.TinkerersWorkbench);
            if (player.HasItem(ItemType<PocketCrimsonAltar>()) || player.HasItem(ItemType<PocketDemonAltar>()))
                tiles.Add(TileID.DemonAltar);
            if (player.HasItem(ItemType<PocketImbuingStation>()))
                tiles.Add(TileID.ImbuingStation);
            if (player.HasItem(ItemType<PocketCookingPots>()))
                tiles.Add(TileID.CookingPots);
            if (player.HasItem(ItemType<PocketDyeVat>()))
                tiles.Add(TileID.DyeVat);
            if (player.HasItem(ItemType<PocketHeavyWorkBench>()))
                tiles.Add(TileID.HeavyWorkBench);
            if (player.HasItem(ItemType<PocketHMAnvils>()))
                tiles.Add(TileID.MythrilAnvil);
            if (player.HasItem(ItemType<PocketForges>()))
                tiles.Add(TileID.AdamantiteForge);
            if (player.HasItem(ItemType<PocketBookcases>()))
                tiles.Add(TileID.Bookcases);
            if (player.HasItem(ItemType<PocketCrystalBall>()))
                tiles.Add(TileID.CrystalBall);
            if (player.HasItem(ItemType<PocketAutohammer>()))
                tiles.Add(TileID.Autohammer);
            if (player.HasItem(ItemType<PocketAncientManipulator>()))
                tiles.Add(TileID.LunarCraftingStation);
            return tiles.ToArray();

        }
    }
}