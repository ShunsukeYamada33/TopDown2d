using UnityEngine;

public class DestroyableWall : MonoBehaviour
{
    [SerializeField] private GameObject experience;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var explosion = collision.GetComponent<ExplosionObject>();
        if(explosion != null)
        {
            Instantiate(experience, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
