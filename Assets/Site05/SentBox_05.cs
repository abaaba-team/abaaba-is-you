using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SentBox_05 : MonoBehaviour
{
    public GameObject destination;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!target)
            if (other.tag == "Box")
            {
                Vector3 move = destination.transform.position;
                other.gameObject.transform.position = move;
            }

    }
}
