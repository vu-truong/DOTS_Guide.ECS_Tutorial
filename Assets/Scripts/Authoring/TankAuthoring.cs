using Unity.Entities;

public class TankAuthoring : UnityEngine.MonoBehaviour
{
}

class TankBaker : Baker<TankAuthoring>
{
    public override void Bake(TankAuthoring authoring)
    {
        AddComponent<Tank>();
    }
}