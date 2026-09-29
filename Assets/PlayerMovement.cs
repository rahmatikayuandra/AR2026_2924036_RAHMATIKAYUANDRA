using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Vector3 movement = Vector3.zero;

        if (Keyboard.current.wKey.isPressed)
        {
            movement.z += 1;
        }

        if (Keyboard.current.sKey.isPressed)
        {
            movement.z -= 1;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            movement.x -= 1;
        }

        if (Keyboard.current.dKey.isPressed)
        {
            movement.x += 1;
        }

        transform.position += movement.normalized * speed * Time.deltaTime;
    }
}