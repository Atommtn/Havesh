using Havesh.Grains.Common;

namespace Havesh.Grains.GrainState;

[Serializable]
public class HaveshGrainState<T> : InitializableState
{
    public T? Item { get; set; }
}