using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitAnnounce_4 : MonoBehaviour
{
    public bool isHit;
    // Start is called before the first frame update
    void Start()
    {
        isHit = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Wall")
        {
            isHit = true;
            print("Hit" + collision.collider.name + "!!!");
        }
    }

}
