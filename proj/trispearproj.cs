using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace earthblood.proj
{
	public class trispearproj : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.name = "Trispear";
			projectile.width = 64;
			projectile.height = 64;
			projectile.aiStyle = 19;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.scale = 1.0f;
			projectile.hide = true;
			projectile.ownerHitCheck = true;
			projectile.melee = true;
			projectile.alpha = 0;
			Main.projFrames[projectile.type] = 4;
		}

		public float movementFactor // move speed
		{
			get { return projectile.ai[0]; }
			set { projectile.ai[0] = value; }
		}

		public override void AI()
		{
			projectile.frameCounter++;
			if (projectile.frameCounter > 4)
			{
				projectile.frameCounter = 0;
				projectile.frame++;
				if (projectile.frame > 4)
				{
					projectile.frame = 0;
				}
			}

			Player projOwner = Main.player[projectile.owner];
			Vector2 ownerMountedCenter = projOwner.RotatedRelativePoint(projOwner.MountedCenter, true);
			projectile.direction = projOwner.direction;
			projOwner.heldProj = projectile.whoAmI;
			projOwner.itemTime = projOwner.itemAnimation;
			projectile.position.X = ownerMountedCenter.X - (float)(projectile.width / 2);
			projectile.position.Y = ownerMountedCenter.Y - (float)(projectile.height / 2);
			if (!projOwner.frozen)
			{
				if (movementFactor == 0f) 
				{
					movementFactor = 1f; //1f
					projectile.netUpdate = true; 
				}
				if (projOwner.itemAnimation < projOwner.itemAnimationMax / 2.25f) //2.25f
				{
					movementFactor -= 0.75f; //0.75f
				}
				else 
				{
					movementFactor += 1.5f; //1.5f
				}
			}
			projectile.position += projectile.velocity * movementFactor;
			if (projOwner.itemAnimation == 0)
			{
				projectile.Kill();
			}
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + MathHelper.ToRadians(135f);
			if (projectile.spriteDirection == -1)
			{
				projectile.rotation -= MathHelper.ToRadians(90f);
			}

		}
	}
}
