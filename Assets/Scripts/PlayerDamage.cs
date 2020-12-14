using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(transform.parent.GetComponent<PlayerBehaviour>().isAttacc)
        {
            foreach(var it in FindObjectsOfType<SlimeBehaviour>())
            {
                if(it.GetComponent<CapsuleCollider2D>().IsTouching(GetComponent<Collider2D>()))
                {
                    Destroy(collision.gameObject);
                }
            }
        }
    }
}
