using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace tutorial.Tiles
{
    public class DanTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true; 
            Main.tileMergeDirt[Type] = true;
            Main.tileLighted[Type] = true;
            AddMapEntry(new Color(100,150,200));
        }
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.5f;
            g = 0.75f;
            b = 1f;
        }
        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }
}
