using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace earthblood.dust
{
	public class death : ModDust
	{
		public override void OnSpawn(Dust dust)
		{
			dust.velocity *= 0.5f;
			dust.noGravity = true;
			dust.frame = new Rectangle(0, Main.rand.Next(4) * 16, 16, 16);
			dust.scale = 2f;
		}

		public override bool Update(Dust dust)
		{
			dust.position += dust.velocity;
			dust.rotation += dust.velocity.X * 0.15f;
			dust.scale *= 0.99f;
			float light = 0.1f * dust.scale;
			Lighting.AddLight(dust.position, light, light, light);
			if (dust.scale < 0.75f)
			{
				dust.active = false;
			}
			return false;
		}
	}
}