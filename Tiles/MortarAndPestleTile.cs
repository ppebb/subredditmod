using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Enums;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace rterrariamod.Tiles
{
    public class MortarAndPestleTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = false;
            Main.placementPreview = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.Table, TileObjectData.newTile.Width, 1);
            TileObjectData.addTile(Type);
            drop = ModContent.ItemType<Items.MortarAndPestle>();
            dustType = DustID.Stone;
            soundType = SoundID.Tink;
            AddMapEntry(new Color(75, 75, 75));
        }

        [System.Obsolete]
        public override void RightClick(int i, int j)
        {
            Player player = Main.player[Main.myPlayer];
            if (player.HeldItem.type == ItemID.CrystalBall)
            {
                Main.PlaySound(SoundID.Item21, player.position);
                Item item = player.HeldItem;
                if (ItemLoader.ConsumeItem(item, player) && item.stack > 0)
                    item.stack--;
                player.QuickSpawnItem(ModContent.ItemType<Items.CrystalPowder>(), Main.rand.Next(1, 4));
            }
        }
    }
}
