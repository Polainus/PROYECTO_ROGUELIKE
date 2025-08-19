using UnityEngine;

public class ComponentedeMovimiento : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveDir;

    private static readonly Vector2 isoRight = new Vector2(1, 0.5f).normalized;
    private static readonly Vector2 isoUp = new Vector2(-1, 0.5f).normalized;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetMoveInput(Vector2 input)
    {
        moveDir = input.x * isoRight + input.y * isoUp;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveDir * moveSpeed;
    }
}
