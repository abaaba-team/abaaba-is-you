using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corrPos_4 : MonoBehaviour
{
    float currX;
    float currZ;

    bool playerIn;

    // Start is called before the first frame update
    void Start()
    {
        playerIn = false;
    }

    // Update is called once per frame
    void Update()
    {
        currX = gameObject.transform.position.x;
        currZ = gameObject.transform.position.z;

        if (!playerIn)
        {
            gameObject.transform.position = new Vector3(Mathf.RoundToInt(currX), transform.position.y, Mathf.RoundToInt(currZ));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Player")
        {
            playerIn = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.collider.name == "Player")
        {
            playerIn = false;
        }
    }

}
