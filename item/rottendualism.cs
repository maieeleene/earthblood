using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace earthblood.item
{
	public class rottendualism : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Rotten Dualism";
			item.damage = 16;
			item.crit = 4;
			item.melee = true;
			item.width = 48;
			item.height = 48;
			item.toolTip = "Double-edged, double-contaminated";
			item.useTime = 80;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 6;
			item.value = 15000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "slab", 1);
			recipe.AddIngredient(ItemID.EbonstoneBlock, 25);
			recipe.AddIngredient(ItemID.CrimstoneBlock, 25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			if (Main.rand.Next(1, 4) == 1 )
			{
				target.AddBuff(BuffID.Poisoned, 240);
			}
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(5) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("death"));
			}
		}

	}
}
