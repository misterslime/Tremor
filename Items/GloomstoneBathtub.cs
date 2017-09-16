using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GloomstoneBathtub : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 64;
			item.height = 32;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 1;
			item.rare = 1;
			item.consumable = true;
			item.value = 2000;
			item.createTile = mod.TileType("GloomstoneBathtub");
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gloomstone Bathtub");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Gloomstone", 14);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
