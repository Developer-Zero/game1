using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4f;
    public float maxSpeed = 8f;
    public float friction = 0.1f;
    public Vector2 velocity = Vector2.zero;

    void Update()
    {
        velocity -= new Vector2(speed * Time.deltaTime / friction, speed * Time.deltaTime / friction);

        Vector2 input = Vector2.zero;

        if (Keyboard.current.wKey.isPressed)
            input.y += 1;

        if (Keyboard.current.sKey.isPressed)
            input.y -= 1;

        if (Keyboard.current.aKey.isPressed)
            input.x -= 1;

        if (Keyboard.current.dKey.isPressed)
            input.x += 1;

        Vector2 movement = input.normalized * speed * Time.deltaTime;
        velocity += movement;

        velocity = new Vector2(Mathf.Min(velocity.x, maxSpeed), Mathf.Min(velocity.y, maxSpeed));

        transform.position += new Vector3(velocity.x, 0f, velocity.y);
    }
}