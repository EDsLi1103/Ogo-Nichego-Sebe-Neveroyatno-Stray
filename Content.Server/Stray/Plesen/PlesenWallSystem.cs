using Content.Shared.Stray.Plesen.PlesenWall;
using JetBrains.Annotations;

namespace Content.Server.Stray.Plesen.PlesenWall;

[UsedImplicitly]
public sealed class PlesenWallSystem : SharedPlesenWallSystem
{
    public override void del(EntityUid toDel){
        EntityManager.QueueDeleteEntity(toDel);
    }
}
