using Unity.Entities;

// Authoring MonoBehaviours are regular GameObject components.
// They constitute the inputs for the baking systems which generates ECS data.
public class TurretAuthoring : UnityEngine.MonoBehaviour
{
    public UnityEngine.GameObject CannonBallPrefab;
    public UnityEngine.Transform CannonBallSpawn;
}

// Bakers convert authoring MonoBehaviours into entities and components.
class TurretBaker : Baker<TurretAuthoring>
{
    public override void Bake(TurretAuthoring authoring)
    {
        AddComponent(new Turret
        {
            // By default, each authoring GameObject turns into an Entity.
            // Given a GameObject (or authoring component), GetEntity looks up the resulting Entity.
            CannonBallPrefab = GetEntity(authoring.CannonBallPrefab),
            CannonBallSpawn = GetEntity(authoring.CannonBallSpawn)
        });

        // Enableable components are always initially enabled.
        AddComponent<Shooting>();
    }
}