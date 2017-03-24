using Terraria.ID;
using Terraria.ModLoader;

namespace earthblood.item
{
	public class slab : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Slab";
			item.damage = 7;
			item.crit = 35;
			item.melee = true;
			item.width = 48;
			item.height = 48;
			item.toolTip = "It was more like a large hunk of stone";
			item.useTime = 35;
			item.useAnimation = 35;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 1500;
			item.rare = -1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
