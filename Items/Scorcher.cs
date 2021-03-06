using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Scorcher : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 178;
			item.width = 14;
			item.height = 84;
			item.noUseGraphic = true;
			item.melee = true;
			item.useTime = 30;
			item.shoot = mod.ProjectileType("ScorcherPro");
			item.shootSpeed = 4f;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = 210000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Scorcher");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "AncientTechnology", 1);
			recipe.AddIngredient(3458, 30);
			recipe.AddIngredient(null, "FireFragment", 25);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
