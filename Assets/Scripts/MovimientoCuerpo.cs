using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoCuerpo : MonoBehaviour
{
    public float velocidad = 4f;

    private Rigidbody2D rb;
    
    private Vector2 movimiento;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        movimiento = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movimiento * velocidad;

    }
}