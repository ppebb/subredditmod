using Terraria;
using Terraria.ModLoader;

/*
namespace rterrariamod.Buffs
{
    public class PossessedShieldBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Possessed Shield");
            Description.SetDefault("The Possessed Shield will defend you from enemies\nIncrease defense by 8");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 8;
            if (player.ownedProjectileCounts[ModContent.ProjectileType<PossessedShieldSummon>()] > 0)
            {
                player.buffTime[buffIndex] = 18000;
            }
            else
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
        }
    }
}
*/