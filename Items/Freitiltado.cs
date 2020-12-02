using Terraria.ID;
using Terraria.ModLoader;

namespace FreitasMod.Items
{	
	public class Freitiltado : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Freitiltado"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a basic modded sword.");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.melee = true;
			item.width = 28;
			item.height = 24;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 3;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}