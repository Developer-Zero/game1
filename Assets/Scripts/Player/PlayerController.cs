using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 4f;
    private Rigidbody2D rb;
    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Vector2 input = Vector2.zero;
        if (Keyboard.current.wKey.isPressed)
            input.y += 1;
        if (Keyboard.current.sKey.isPressed)
            input.y -= 1;

        if (Keyboard.current.aKey.isPressed)
            input.x -= 1;

        if (Keyboard.current.dKey.isPressed)
            input.x += 1;

        rb.linearVelocity += input.normalized * speed;

        // Animations
        if (input.y > 0)
            anim.SetInteger("State", 4);
        else if (input.y < 0)
            anim.SetInteger("State", 1);
        else if (input.x > 0)
            anim.SetInteger("State", 2);
        else if (input.x < 0)
            anim.SetInteger("State", 3);
        else
            anim.SetInteger("State", 0);
    }
}