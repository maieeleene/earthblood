using Terraria.ModLoader;

namespace lowtech
{
	class lowtech : Mod
	{
		public lowtech()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
