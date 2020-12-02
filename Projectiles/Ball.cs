using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace FreitasMod.Projectiles
{
    class Ball : ModProjectile
	{
		bool itWasWet = false;

		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("English Display Name Here");
		}

		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.thrown = true;
			projectile.noDropItem = true;
			projectile.penetrate = 5;
			projectile.ignoreWater = false;
		}

		public override void AI()
        {

			if (projectile.velocity.Y > 16f) { 

				projectile.velocity.Y = 16f;
            }

			projectile.rotation += 0.4f * (float)projectile.direction;

            if (projectile.wet)
			{
				if (!itWasWet)
				{
					itWasWet = true;
					OnEnterWater();
				}

				if (projectile.velocity.Y < -16f)
				{
					projectile.velocity.Y = -16f;
				}
				projectile.velocity.Y -= .2f;
				projectile.velocity.Y *= 0.99f;
				projectile.velocity.X *= 0.99f;
			}
            else
			{
                if (itWasWet)
                {
					itWasWet = false;
					OnExitWater();
				}
				projectile.velocity.Y = projectile.velocity.Y + 0.2f;
			}
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			projectile.penetrate--;
			if (projectile.penetrate <= 0)
			{
				projectile.Kill();
			}
			else
			{
				Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
				Main.PlaySound(SoundID.Item10, projectile.position);
				if (projectile.velocity.X != oldVelocity.X)
				{
					projectile.velocity.X = -oldVelocity.X * .8f;
				}
				if (projectile.velocity.Y != oldVelocity.Y)
				{
					projectile.velocity.Y = -oldVelocity.Y * .8f;
				}
			}
			return false;
		}

        public override void Kill(int timeLeft)
		{
			Dust.NewDust(projectile.position, 30, 30, 31, 0f, 0f, 0, new Color(255, 255, 255), 1f);
			Main.PlaySound(SoundID.Item10, projectile.position);
		}

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
			projectile.Kill();
		}

		void OnEnterWater()
		{
			projectile.penetrate--;
		}

		void OnExitWater()
        {
			projectile.velocity.Y *= .5f;
        }
    }
}
