using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using rterrariamod.Items;

namespace rterrariamod
{
    public class RGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.Mothron)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<BrokenHeroBar>(), Main.rand.Next(0, 4));
            }

            if (npc.type == NPCID.Plantera)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<TerraFragment>(), Main.rand.Next(0, 5));

                if (Main.rand.NextFloat() < .025f)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Accessories.Antidote>());
                }
            }


            if (npc.type == NPCID.BlackRecluse || npc.type == NPCID.ToxicSludge || npc.type == NPCID.QueenBee || npc.type == NPCID.SpikedJungleSlime || npc.type == NPCID.Salamander || npc.type == NPCID.Salamander2 || npc.type == NPCID.Salamander3 || npc.type == NPCID.Salamander4 || npc.type == NPCID.Salamander5 || npc.type == NPCID.Salamander6 || npc.type == NPCID.Salamander7 || npc.type == NPCID.Salamander8 || npc.type == NPCID.Salamander9)
            {
                if (Main.rand.NextFloat() < .025f)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Accessories.Antidote>());
                }
            }

            if (NPCID.Sets.Skeletons.Contains(npc.type))
            {
                if (Main.rand.NextFloat() < .0075f)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Accessories.SkeletonSkull>());
                }
            }

            if (npc.type == NPCID.Hornet || npc.type == NPCID.HornetFatty || npc.type == NPCID.HornetLeafy || npc.type == NPCID.HornetHoney || npc.type == NPCID.HornetSpikey || npc.type == NPCID.HornetStingy || npc.type == NPCID.BigHornetFatty || npc.type == NPCID.BigHornetHoney || npc.type == NPCID.BigHornetLeafy || npc.type == NPCID.BigHornetSpikey || npc.type == NPCID.BigHornetStingy || npc.type == NPCID.BigMossHornet || npc.type == NPCID.GiantMossHornet || npc.type == NPCID.LittleHornetFatty || npc.type == NPCID.LittleHornetHoney || npc.type == NPCID.LittleHornetLeafy || npc.type == NPCID.LittleHornetSpikey || npc.type == NPCID.LittleHornetStingy || npc.type == NPCID.LittleMossHornet || npc.type == NPCID.MossHornet)
            {
                if (Main.rand.NextFloat() < .05f)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Accessories.BeehiveMiniature>());
                }
                if (Main.rand.NextFloat() < .025f)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Accessories.Antidote>());
                }
            }

            if (npc.type == NPCID.BlackRecluse || npc.type == NPCID.BlackRecluseWall)
            {
                if (Main.rand.NextFloat() < .05f)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Accessories.SpiderEggSack>());
                }
            }

            if (npc.type == NPCID.KingSlime)
            {
                if (Main.rand.NextFloat() < .1f)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Accessories.RoyalDefense>());
                }
            }
            /*if (npc.type == NPCID.PossessedArmor)
            {
                if (Main.rand.NextFloat() < .04f)
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Weapons.PossessedShield>());
                }
            }*/
        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.TravellingMerchant)
            {
                if (Main.rand.NextFloat() < 0.1f)
                {
                    shop.item[nextSlot].SetDefaults(ModContent.ItemType<HeartLocket>());
                    shop.item[nextSlot].shopCustomPrice = 20000;
                }
            }

            if (type == NPCID.Merchant)
            {
                if (Main.hardMode && NPC.savedWizard)
                {
                    //shop.item[nextSlot].SetDefaults(ModContent.ItemType<MortarAndPestle>());
                    //shop.item[nextSlot].shopCustomPrice = 10000;
                }
            }
        }
    }
}