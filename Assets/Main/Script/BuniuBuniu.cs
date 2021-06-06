using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuniuBuniu : MonoBehaviour
{
    public float freq;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shake", 0, freq);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void shake()
    {
        if (gameObject.transform.localScale.x != 1)
        {
            
            gameObject.transform.localScale = new Vector3(1, transform.localScale.y, 1);

        }
        else
        {
            gameObject.transform.localScale = new Vector3(0.8f, transform.localScale.y, 0.8f);
        }

    }
}
