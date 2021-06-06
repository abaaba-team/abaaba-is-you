using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossDetect_4 : MonoBehaviour
{
    public GameObject box;

    public bool hitTwo;

    private bool isPlayer;
    private bool isWall;
    private bool isBox;
    public LayerMask wall;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.anyKey)
        //{
        //    Collider[] cs = Physics.OverlapSphere(gameObject.transform.position, 0.5f);
        //    Collider[] csWall = Physics.OverlapSphere(gameObject.transform.position, 0.5f , wall);
        //    foreach (Collider o in cs)
        //    {
        //        print(gameObject.name + ": " + o.name);
        //    }
        //    foreach (Collider ow in csWall)
        //    {
        //        print(gameObject.name + ": "+ ow.name);
        //    }
        //}
        gameObject.transform.position = box.transform.position;
        if ((isPlayer && isWall) || (isPlayer && isBox))
        {
            print("Hit!!!");
            print(" p: " + isPlayer + " b: " + isBox + " w: " + isWall);
            hitTwo = true;
        }
        else
        {
            print("noHit");
            hitTwo = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        //print(gameObject.name + ": " + other.name);
        if (other.name == "Player")
        {
            isPlayer = true;
            print(gameObject.name + " isPlayer");
        }

        if (other.tag == "Wall")
        {
            isWall = true;
            print(gameObject.name + " isWall");
        }

        if (other.tag == "Box")
        {
            isBox = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            isPlayer = false;
        }

        if (other.tag == "Wall")
        {
            isWall = false;
        }
        if (other.tag == "Box")
        {
            isBox = false;
        }
    }
}
