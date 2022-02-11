using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace tutorial.Items.Weapons
{
	public class Dan : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dan"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a basic modded sword.");
		}

		public override void SetDefaults()
		{
			Item.damage = 3;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40; // The item texture's width.
			Item.height = 40; // The item texture's height.
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = Item.sellPrice(copper:10);
			Item.rare = ItemRarityID.Expert;
			Item.useTurn = true;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.Register();
		}
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                // Emit dusts when the sword is swung
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<Dusts.Sparkle1>());
            }
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// Inflict the OnFire debuff for 1 second onto any NPC/Monster that this hits.
			// 60 frames = 1 second
			target.AddBuff(BuffID.OnFire, 60);
		}
	}
}