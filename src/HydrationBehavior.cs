using Vintagestory.API.Client;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.Common;
using Vintagestory.API.Server;
using Vintagestory.API.MathTools;
using System.Text;
using Vintagestory.API.Datastructures;

namespace MaddieKnz.Hydration
{    
    public class HydrationBehavior : EntityBehavior
    {
        const string HYDRATION = "hydration";
        new EntityAgent entity;
        long listenerId;

        public override string PropertyName()
        {
            return HYDRATION;
        }

        public HydrationBehavior(Entity entity) : base(entity)
        {
            this.entity = entity as EntityAgent;
        }

        public override void Initialize(EntityProperties properties, JsonObject attributes)
        {
            base.Initialize(properties, attributes);

            if (entity is EntityPlayer) {
                listenerId = entity.World.RegisterGameTickListener(Tick, 6000);

                entity.Stats.Register(HYDRATION);
            }
        }

        
        public override void OnEntityDespawn(EntityDespawnReason despawn)
        {
            base.OnEntityDespawn(despawn);

            if (listenerId > 0) {
                entity.World.UnregisterGameTickListener(listenerId);
            }
        }

        private void Tick(float dt)
        {

        }
    }
}