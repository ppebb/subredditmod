using Terraria;
using Terraria.ModLoader;

namespace rterrariamod.Prefixes
{
    public class Affluent : ModPrefix
    {
        public override float RollChance(Item item)
        // Chance to roll this prefix   
            => 1f;

        public override bool CanRoll(Item item)
        // Can you get this prefix?
            => true;

        public override PrefixCategory Category
        // Only for accessories
            => PrefixCategory.Accessory;

        public override void ModifyValue(ref float valueMult)
        {
            // Modifies value of item after prefix
            valueMult *= 1.45f;
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            // Gives more coins from enemies
            Player player = Main.LocalPlayer;
            player.coins = true;
        }
    }
}
