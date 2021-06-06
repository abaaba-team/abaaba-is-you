using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbaAba : MonoBehaviour
{
    public float freq;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("openMouse", 0, freq);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void openMouse()
    {
        if (gameObject.transform.localScale.x != 0.1f)
        {
            gameObject.transform.localScale = new Vector3(0.1f , transform.localScale.y , transform.localScale.z);

        }
        else
        {
            gameObject.transform.localScale = new Vector3(0.2f, transform.localScale.y, transform.localScale.z);
        }

    }
}
