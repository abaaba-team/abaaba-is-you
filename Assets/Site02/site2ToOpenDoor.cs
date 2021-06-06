using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class site2ToOpenDoor : MonoBehaviour
{
    public GameObject target;
    public Material m;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Box"))
        {
            target.gameObject.GetComponent<BoxCollider>().isTrigger = true;
            target.gameObject.GetComponent<MeshRenderer>().material = m;
            target.gameObject.layer = 0;
        }
    }
}
