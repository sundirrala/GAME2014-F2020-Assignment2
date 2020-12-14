using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformBehaviour : MonoBehaviour
{
    public Transform start;
    public Transform end;

    private Vector3 distance;

    // Start is called before the first frame update
    void Start()
    {
        distance = end.position - start.position;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.position = new Vector3(start.position.x + Mathf.PingPong(Time.time, distance.x), start.position.y, 0.0f);
    }
}
