using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class JawFish : ModItem
	{
		public override void SetDefaults()
		{

			item.questItem = true;
			item.maxStack = 1;
			item.width = 26;
			item.height = 26;
			item.uniqueStack = true;
			item.rare = -11;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jaw Fish");
			Tooltip.SetDefault("");
		}

		public override bool IsQuestFish()
		{
			return true;
		}

		public override bool IsAnglerQuestAvailable()
		{
			return NPC.downedBoss2;
		}

		public override void AnglerQuestChat(ref string description, ref string catchLocation)
		{
			description = "You should have seen my face when I found this badass for the first time! Wow! Go catch it for me, but don't yawn, otherwise it will bite you in the face and I won't be able to laugh over it.";
			catchLocation = "Anywhere";
		}
	}
}
