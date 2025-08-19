using UnityEngine;

public class ComponentedeProyectil : MonoBehaviour
{

    [Header("Datos del Proyectil")]
    public int damage = 10;
    public float speed = 12f;
    public float lifetime = 3f;
        private Rigidbody2D rb;



    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Destroy(gameObject, lifetime);

    }
    public void SetDirection(Vector2 dir)
    {
        rb.linearVelocity = dir.normalized * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        ComponenteDeVida health = other.GetComponent<ComponenteDeVida>();
        if (health != null)
        {
            health.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
