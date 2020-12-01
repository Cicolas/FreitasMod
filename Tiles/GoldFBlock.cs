using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace FreitasMod.Tiles
{
    public class GoldFBlock : ModTile
    {
        public override void SetDefaults()
        {
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
            TileObjectData.newTile.Width = 2; 
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.Origin = new Point16(1, 2);
            TileObjectData.addTile(Type);

            Main.tileFrameImportant[Type] = true;
            Main.tileSolid[Type] = false;
            Main.tileNoAttach[Type] = true;
            dustType = mod.DustType("Sparkle");
            drop = mod.ItemType("GoldF");
            disableSmartCursor = true;
            AddMapEntry(new Color(200, 200, 200));
        }
    }
}
