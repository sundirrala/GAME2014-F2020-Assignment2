using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    JoystickBehaviour joystick;
    [SerializeField]
    Transform raycast;
    [SerializeField]
    float maxVelX, jumpVelY, joystickSensitivity;
    [SerializeField]
    LayerMask platforms;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(joystick.localPosition.x >= joystickSensitivity)
        {
            rb.velocity = new Vector2(joystick.localPosition.x * maxVelX * Time.deltaTime, rb.velocity.y);
        }
        else if (joystick.localPosition.x <= -joystickSensitivity)
        {
            rb.velocity = new Vector2(joystick.localPosition.x * maxVelX * Time.deltaTime, rb.velocity.y);
        }

        if (joystick.localPosition.y >= 0.5f)
        {
            RaycastHit2D ray = Physics2D.Linecast(transform.position, raycast.transform.position, platforms);

            if (ray.collider != null)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpVelY);
            }
        }

        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, -10.0f);
    }
}
