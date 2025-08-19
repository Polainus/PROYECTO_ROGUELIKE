using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Header("Movimiento")]
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 rawInput;
    
    // Matriz de conversión a isométrico
    private static readonly Vector2 isoRight = new Vector2(1, 0.5f).normalized;
    private static readonly Vector2 isoUp = new Vector2(-1, 0.5f).normalized;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        rawInput = context.ReadValue<Vector2>(); // WASD o joystick
    }

    void FixedUpdate()
    {
        // Convertimos input cartesiano a isométrico
        Vector2 moveDir = rawInput.x * isoRight + rawInput.y * isoUp;
        rb.linearVelocity = moveDir * moveSpeed;
    }
}
