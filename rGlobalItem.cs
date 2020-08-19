using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using rterrariamod.Prefixes;
using rterrariamod.Items.Accessories;
using System.Collections.Generic;

namespace rterrariamod
{
    public class RGlobalItem : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (ModContent.GetInstance<rTerrariaModConfig>().skeletonImmunityConfig)
            {
                if (item.type == ModContent.ItemType<SkeletonSkull>() || item.type == ModContent.ItemType<SummonersMask>())
                {
                    TooltipLine line = new TooltipLine(mod, "SkeletonImmunity", "Makes most pre-hardmode skeletons friendly")
                    {
                        overrideColor = Color.White
                    };
                    tooltips.Add(line);
                }
            }
            if (item.prefix == ModContent.PrefixType<Affluent>())
            {
                TooltipLine line = new TooltipLine(mod, "PrefixAffluent", "Hitting enemies will sometimes drop extra coins\nAffect does not stack")
                {
                    isModifier = true
                };
                tooltips.Add(line);
            }
            if (item.prefix == ModContent.PrefixType<Shamanic>())
            {
                item.rare = ItemRarityID.Red;
                TooltipLine line = new TooltipLine(mod, "PrefixShamanic", "10% increased minion damage\nIncreased minion knockback")
                {
                    isModifier = true
                };
                tooltips.Add(line);
            }
            if (item.prefix == ModContent.PrefixType<Sparkling>())
            {
                TooltipLine line = new TooltipLine(mod, "PrefixSparkling", "15% increased minion damage\nMax minions increased by 2")
                {
                    isModifier = true
                };
                tooltips.Add(line);
            }
        }
    }
}