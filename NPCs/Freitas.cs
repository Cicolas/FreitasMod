using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using Terraria.Localization;

namespace FreitasMod.NPCs
{
    public class Freitas : ModNPC
    {
        public override void SetStaticDefaults()
        {
            
            Main.npcFrameCount[npc.type] = 25;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
            
        }

        public override void SetDefaults()
        {
            npc.lifeMax = 250;
            npc.width = 18;
            npc.height = 40;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 15;
            npc.knockBackResist = 0.5f;
            npc.friendly = true;
            npc.townNPC = true;
            animationType = NPCID.Guide;
        }
    
        public override string GetChat()
        {
            WeightedRandom<string> possibleQuotes = new WeightedRandom<string>();

            possibleQuotes.Add("Salve Nícolas Carvalho, bora X1 R6");
            possibleQuotes.Add("Mateus Benetete uma vez disse: X1 Paladinos Incelzinhos?");
            possibleQuotes.Add("Meu nome é Ronaldo.");

            return possibleQuotes;
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28");
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                shop = true;
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.AlphabetStatueF);
        }
    }
}
