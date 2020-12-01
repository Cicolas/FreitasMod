using Terraria.ID;
using Terraria.ModLoader;

namespace FreitasMod.Items.Placeable
{
	public class PlatinumF : ModItem
	{
		public override void SetDefaults()
		{
			item.value = 10000000;
			item.width = 24;
			item.height = 34;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.rare = ItemRarityID.Purple;
			item.maxStack = 99;
			item.createTile = ModContent.TileType<Tiles.PlatinumFBlock>();
		}
	}
}