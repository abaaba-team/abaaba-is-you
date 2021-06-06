using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_05 : MonoBehaviour
{
    public GameObject target;
    public Material m;
    public bool canMove;

    // Start is called before the first frame update
    void Start()
    {

        canMove = false;
        gameObject.layer = 8;
    }

    // Update is called once per frame
    void Update()
    {

        if (target)
        {
            canMove = false;
        }
        else
        {
            canMove = true;
        }

        if (canMove == true)
        {
            gameObject.GetComponent<MeshRenderer>().material = m;
            gameObject.layer = 0;
        }
        else
        {
            gameObject.layer = 8;
        }
    }
}
