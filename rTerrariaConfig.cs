using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace rterrariamod
{
#pragma warning disable IDE1006 // Naming Styles
    public class rTerrariaModConfig : ModConfig
#pragma warning restore IDE1006 // Naming Styles
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        [Label("Toggles the song played in the purity biome")]
        [DefaultValue(true)]
        public bool whatconfig;

        [Label("Toggles the Skeleton immunity effect given by some accessories")]
        [DefaultValue(true)]
        public bool skeletonImmunityConfig;
    }
}
