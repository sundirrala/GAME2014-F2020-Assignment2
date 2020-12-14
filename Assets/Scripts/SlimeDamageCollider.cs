using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlimeDamageCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            transform.parent.GetComponent<Animator>().SetInteger("state", 1);
            FindObjectOfType<PlayerBehaviour>().health -= 10.0f * Time.deltaTime;
            FindObjectOfType<HealthBarBehaviour>().UpdateHealth(FindObjectOfType<PlayerBehaviour>().health);
            
            if(FindObjectOfType<PlayerBehaviour>().health < 0)
            {
                SceneManager.LoadScene("Gameover Screen");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.parent.GetComponent<Animator>().SetInteger("state", 0);
        }
    }
}
