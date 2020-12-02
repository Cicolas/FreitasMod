using Terraria.ID;
using Terraria.ModLoader;

namespace FreitasMod.Items
{
    class BallLauncher : ModItem
    {
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Freitiltado"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			// Tooltip.SetDefault("This is a basic modded sword.");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 24;
			item.useTime = 20;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<Projectiles.Ball>();
			item.shootSpeed = 10;
			item.damage = 20;
		}
	}
}
