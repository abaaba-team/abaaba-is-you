using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeToBlocker : MonoBehaviour
{
    public bool canMove; 
    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        canMove = true;
        foreach(Transform child in this.transform)
        {
            if(child.GetComponent<CrossDetect>().hitTwo == true)
            {
                canMove = false;
            }
        }

        if (!canMove)
        {
            gameObject.layer = 8;
        }
        else
        {
            gameObject.layer = 0;
        }
    }
}
