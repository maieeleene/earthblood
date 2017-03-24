using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace earthblood.item
{
	public class burningstaff : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Burning staff";
			item.damage = 4;
			item.crit = 20;
			item.melee = true;
			item.width = 48;
			item.height = 48;
			item.toolTip = "Inquisition's weapon";
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 1500;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 16);
			recipe.AddIngredient(ItemID.TikiTorch, 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			if (Main.rand.Next(1, 2) == 1 )
			{
				target.AddBuff(BuffID.OnFire, 1200);
			}

		}
	}
}
