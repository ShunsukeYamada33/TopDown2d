using UnityEngine;
using UnityEngine.AI;

public class Tracer : MonoBehaviour
{
    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    public void Trace(Vector2 current, Vector2 target)
    {
        // è\ï™Ç…ãﬂÇ¢èÍçáÇÕí«ê’ÇµÇ»Ç¢
        if (Vector2.Distance(current, target) < 0.1f) return;

        var path = new NavMeshPath();
        NavMesh.CalculatePath(current, target, NavMesh.AllAreas, path);

        if(path.corners.Length >= 2)
        {
            var corner = path.corners[1];

            _transform.position = Vector2.MoveTowards(current, corner, 1.0f * Time.deltaTime);
        }
    }
}
