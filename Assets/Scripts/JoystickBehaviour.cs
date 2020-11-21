using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class JoystickBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject joystick;

   
    bool held = false;
    public Vector3 localPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool touched = false;

        foreach (var item in Input.touches)
        {
            touched = true;

            var worldPoint = Camera.main.ScreenToWorldPoint(item.position);

            if(joystick.GetComponent<Collider2D>().OverlapPoint(worldPoint) || held)
            {
                held = true;
                joystick.transform.position = new Vector3(worldPoint.x, worldPoint.y, joystick.transform.position.z);
                localPosition = joystick.transform.position - transform.position;

                if(Vector3.Magnitude(localPosition) > 1.0f)
                {
                    localPosition.Normalize(); // normalizing brings the length back to one.
                    joystick.transform.position =  transform.position + localPosition;
                }
            }
        }

        if(!touched)
        {
            held = false;
            joystick.transform.position = transform.position;
            localPosition = Vector3.zero;
        }
    }
}
