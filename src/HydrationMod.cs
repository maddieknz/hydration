using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

[assembly: ModInfo( "Hydration Mod",
	Description = "Adds hydration needs and items to Vintage Story",
	Website     = "https://github.com/maddieknz/hydration",
	Authors     = new []{ "maddieknz" } )]

namespace MaddieKnz.Hydration
{
	public class HydrationMod : ModSystem
	{
		public override void Start(ICoreAPI api)
		{
			api.RegisterEntityBehaviorClass("hydration", typeof(HydrationBehavior))
		}
		
		public override void StartClientSide(ICoreClientAPI api)
		{
			
		}
		
		public override void StartServerSide(ICoreServerAPI api)
		{
			
		}
	}
}
