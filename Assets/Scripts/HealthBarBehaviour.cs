using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehaviour : MonoBehaviour
{
    const float width = 5.89f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateHealth(float health)
    {
        GetComponent<Image>().rectTransform.sizeDelta = new Vector2(5.89f * (health / 100.0f), GetComponent<Image>().rectTransform.sizeDelta.y);
    }
}
