using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;

namespace tutorial.Items.Weapons
{
	public class CyrusKnife : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dan"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a basic modded sword.");
		}

		public override void SetDefaults()
		{
			Item.damage = 8;
			Item.knockBack = 4f;
			Item.useStyle = ItemUseStyleID.Rapier; // Makes the player do the proper arm motion
			Item.useAnimation = 12;
			Item.useTime = 12;
			Item.width = 40;
			Item.height = 40;
			Item.useTurn = true;
			Item.UseSound = SoundID.Item1;
			Item.noUseGraphic = true; // The sword is actually a "projectile", so the item should not be visible when used
			Item.noMelee = true; // The projectile will do the damage and not the item
			Item.autoReuse = true;

			Item.shoot = ModContent.ProjectileType<Projectiles.Weapons.Cyrus.CyrusKnifeProjectile>(); // The projectile is what makes a shortsword work
			Item.shootSpeed = 2.1f; // This value bleeds into the behavior of the projectile as velocity, keep that in mind when tweaking values
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.Register();
		}
	}
}