using Terraria;
using Terraria.ModLoader;

namespace rterrariamod.Prefixes
{
    public class Shamanic : ModPrefix
    {
        public override float RollChance(Item item)
            => 1f;

        public override bool CanRoll(Item item)
            => item.summon;

        public override PrefixCategory Category
            => PrefixCategory.Magic;

        public override void ModifyValue(ref float valueMult)
        {
            valueMult *= 1.45f;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            Player player = Main.LocalPlayer;
            player.minionDamage += .1f;
            player.minionKB += 3;
        }
    }
}
