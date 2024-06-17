using R3;
using R3.Triggers;
using System;
using UnityEngine;
using UnityEngine.AI;

public class EnemyObject : MonoBehaviour
{
    [SerializeField] private GameObject upObject;
    [SerializeField] private GameObject downObject;
    [SerializeField] private GameObject sideObject;
    [SerializeField] private Vanish vanishObject;
    private CircleCollider2D thisCircleCollider;

    private Vector3Int _direction = Vector3Int.down;
    private Transform _transform;
    public Transform playerTransform;
    private Tracer _tracer;

    private void Awake()
    {
        _transform = transform;
        _tracer = GetComponent<Tracer>();
    }

    private void Update()
    {
        _tracer.Trace(_transform.position, playerTransform.position);
    }

    private void Start()
    {
        vanishObject.gameObject.SetActive(false);
        ChangeAnimation();

        thisCircleCollider = GetComponent<CircleCollider2D>();
        thisCircleCollider.OnTriggerEnter2DAsObservable().Subscribe(OnTriggerEnter2DThisCollider);
    }

    private void ChangeAnimation()
    {
        var x = _direction.x;
        var y = _direction.y;

        // â‘Î’l‚ð”äŠr‚µ‚ÄA‘å‚«‚¢‚Ù‚¤‚ÌˆÚ“®‚ðÌ—p
        if(Mathf.Abs(x) > Mathf.Abs(y))
        {
            sideObject.SetActive(true);
            upObject.SetActive(false);
            downObject.SetActive(false);
            sideObject.transform.localScale = x < 0 ? Vector3.one : new Vector3(-1.0f, 1.0f, 1.0f);
        }
        else
        {
            if(y < 0)
            {
                sideObject.SetActive(false);
                upObject.SetActive(false);
                downObject.SetActive(true);
            }
            else
            {
                sideObject.SetActive(false);
                upObject.SetActive(true);
                downObject.SetActive(false);
            }
        }
    }


    private void OnTriggerEnter2DThisCollider(Collider2D collision)
    {
        var explosion = collision.GetComponent<ExplosionObject>();
        if (explosion != null)
        {
            sideObject.SetActive(false);
            upObject.SetActive(false);
            downObject.SetActive(false);

            vanishObject.gameObject.SetActive(true);
            vanishObject.OnVanishEnd.Subscribe(_ => Destroy(gameObject)).AddTo(gameObject);
        }
    }
}
