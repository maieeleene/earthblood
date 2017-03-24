using earthblood.proj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace earthblood.item
{
	public class trispear : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Trispear";
			item.toolTip = "Shoo";
			item.damage = 40;
			item.useStyle = 5;
			item.useAnimation = 32;
			item.useTime = 32;
			item.shootSpeed = 3.7f;
			item.knockBack = 6.5f;
			item.width = 64;
			item.height = 64;
			item.scale = 1f;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<trispearproj>();
			item.value = 1000;
			item.noMelee = true; 
			item.noUseGraphic = true; 
			item.melee = true;
			item.autoReuse = true; 
		}

		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 1; 
		}
	}
}
