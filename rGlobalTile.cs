using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using rterrariamod.Items;
using rterrariamod.Items.Tools;
using rterrariamod.Items.PocketCrafters;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;

namespace rterrariamod
{
    public class RGlobalTile : GlobalTile
    {
        public override void KillTile(int i, int j, int type, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
            Tile tile = Main.tile[i, j];
            Player player = Main.LocalPlayer;
            if (type == TileID.JunglePlants)
            {
                if (tile.frameX == 18 * 8)
                {
                    if (Main.rand.NextFloat() < .04f)
                    {
                        Item.NewItem(i * 16, j * 16, 16, 16, ItemType<Items.Accessories.OvergrownSpore>());
                    }
                }
            }

            if (type == TileID.DemonAltar)
            {
                if (player.HeldItem.modItem is PurifiedHammer)
                {
                    if (tile.frameX >= 54)
                    {
                        Item.NewItem(i * 16, j * 16, 16, 16, ItemType<CrimsonBits>(), Main.rand.Next(1, 4));
                    }
                    else
                    {
                        Item.NewItem(i * 16, j * 16, 16, 16, ItemType<CorruptBits>(), Main.rand.Next(1, 4));
                    }
                }
            }
        }

        public override int[] AdjTiles(int type)
        {
            Player player = Main.LocalPlayer;
            List<int> tiles = new List<int>();
            if (player.HasItem(ItemType<PocketWorkBenches>()))
            {
                tiles.Add(TileID.WorkBenches);
            }
            if (player.HasItem(ItemType<PocketFurnace>()))
            {
                tiles.Add(TileID.Furnaces);
            }
            if (player.HasItem(ItemType<PocketAnvils>()))
            {
                tiles.Add(TileID.Anvils);
            }
            if (player.HasItem(ItemType<PocketLoom>()))
            {
                tiles.Add(TileID.Loom);
            }
            if (player.HasItem(ItemType<PocketSawmill>()))
            {
                tiles.Add(TileID.Sawmill);
            }
            if (player.HasItem(ItemType<PocketGlassKiln>()))
            {
                tiles.Add(TileID.GlassKiln);
            }
            if (player.HasItem(ItemType<PocketHellforge>()))
            {
                tiles.Add(TileID.Hellforge);
            }
            if (player.HasItem(ItemType<PocketAlchemyTable>()))
            {
                tiles.Add(TileID.AlchemyTable);
            }
            if (player.HasItem(ItemType<PocketCookingPots>()))
            {
                tiles.Add(TileID.CookingPots);
            }
            //if (player.HasItem(ItemType<PocketTinkerersWorkshop>()))
            //{
            //    tiles.Add(TileID.TinkerersWorkbench);
            //}
            return tiles.ToArray();

        }
    }
}