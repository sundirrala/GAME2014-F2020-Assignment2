using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeBehaviour : MonoBehaviour
{
    public float force;
    public Rigidbody2D rigidbody2D;
    public Transform lookAheadPoint;
    public LayerMask collisonLayer;
    public bool isGroundedAhead;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        LookAhead();
        Movement();
    }

    private void LookAhead()
    {
        isGroundedAhead = Physics2D.Linecast(transform.position, lookAheadPoint.position);
        Debug.DrawLine(transform.position, lookAheadPoint.position, Color.red);
    }

    private void Movement()
    {
        if(isGroundedAhead)
        {
            rigidbody2D.AddForce(Vector2.left * force * Time.deltaTime);
            rigidbody2D.velocity *= 0.90f;
        }

    }

   


}
