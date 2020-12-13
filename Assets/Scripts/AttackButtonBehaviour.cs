using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackButtonBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    float time = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<PlayerBehaviour>().isAttacc)
        {
            time += Time.deltaTime;
        }

        if (time >= 1.583f && player.GetComponent<PlayerBehaviour>().isAttacc)
        {
            time = 0.0f;
            player.GetComponent<PlayerBehaviour>().isAttacc = false;
        }



        Debug.Log(player.GetComponent<PlayerBehaviour>().isAttacc.ToString());
    }

    public void onAttackButtPressed()
    {
        Debug.Log("FIrE");
        player.GetComponent<PlayerBehaviour>().isAttacc = true;
        player.GetComponent<Animator>().SetInteger("state", 3);
    }
}
