using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace rterrariamod.Items
{
    public abstract class AltarBits : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Altar Bits");
        }
        public override void SetDefaults()
        {
            item.width = 69;
            item.height = 69;
            item.maxStack = 999;
            item.value = Item.sellPrice(silver: 35);
            item.rare = ItemRarityID.LightRed;
        }
    }

    public class CorruptBits : AltarBits
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'It smells of death and rot'");
        }
    }

    public class CrimsonBits : AltarBits
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Did that just blink at me?'");
        }
    }
}
