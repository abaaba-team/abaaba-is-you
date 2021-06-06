using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class site02NewCrossDetect : MonoBehaviour
{
    public GameObject box;

    public bool hitTwo;

    private bool isPlayer;
    private bool isWall;
    private bool isBox;
    private bool isDoor;
    
    public LayerMask wall;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = box.transform.position;


        if ((isPlayer && isWall) || (isPlayer && isBox) || (isPlayer && isDoor))
        {
            print("Hit!!!");
            print(" p: " + isPlayer + " b: " + isBox + " w: " + isWall + " d: " + isDoor);
            hitTwo = true;  
        }
        else
        {
            print("noHit");
            print(" p: " + isPlayer + " b: " + isBox + " w: " + isWall + " d: " + isDoor);
            hitTwo = false;
        }
        //passDoor();

    }

    //void passDoor()
    //{
    //    if ((GameObject.Find("door01").gameObject.layer == 0) && (isPlayer && isDoor))
    //    {
    //        print("TnoHit");
    //        //hitTwo = false;
    //        box.gameObject.GetComponent<site02NewchangeToBlocker>().canMove = true;
    //    }

    //    if ((GameObject.Find("door02").gameObject.gameObject.layer == 0) && (isPlayer && isDoor))
    //    {

    //        print("TnoHit");
    //        //hitTwo = false;
    //        box.gameObject.GetComponent<site02NewchangeToBlocker>().canMove = true;
    //    }

    //    if ((GameObject.Find("door03").gameObject.gameObject.layer == 0) && (isPlayer && isDoor))
    //    {
    //        print("TnoHit");
    //        //hitTwo = false;
    //        box.gameObject.GetComponent<site02NewchangeToBlocker>().canMove = true;
    //    }
    //}

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

        if (other.tag == "Door")
        {
            isDoor = true;
            print(gameObject.name + " isDoor");
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

        if (other.tag == "Door")
        {
            isDoor = false;
        }

        if (other.tag == "Box")
        {
            isBox = false;
        }
    }

}
