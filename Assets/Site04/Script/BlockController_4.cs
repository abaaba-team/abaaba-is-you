using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController_4 : MonoBehaviour
{
    public Transform block;
    //public float smoothTime;
    //public float maxSpeed;
    public bool[,] map;

    public int posX;
    public int posY;

    //private Vector3 currentVelocity;
    //private bool isOnWall;

    void Start()
    {
        //isOnWall = false;
        bool[,] map = new bool[15, 15]{
            {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false, },
            {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false, },
            {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false, },
            {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false, },
            {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false, },
            {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false, },
            {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false, },
            {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false, },
            {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false, },
            {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false, },
            {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false, },
            {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false, },
            {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false, },
            {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false, },
            {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false, },

        };

        posX = 0;
        posY = 0;
    
    }

    void Update()
    {
        //Debug.Log("inControll");
        if (Input.GetKeyDown(KeyCode.W) && canMove("w"))
        {
            block.transform.position += new Vector3(1.0f, 0f, 0f);
            posY += 1;
        }
        if (Input.GetKeyDown(KeyCode.S) && canMove("s"))
        {
            block.transform.position += new Vector3(-1.0f, 0f, 0f);
            posY -= 1;
        }
        if (Input.GetKeyDown(KeyCode.A) && canMove("a"))
        {
            block.transform.position += new Vector3(0f, 0f, 1.0f);
            posX -= 1;
        }
        if (Input.GetKeyDown(KeyCode.D) && canMove("d"))
        {
            block.transform.position += new Vector3(0f, 0f, -1.0f);
            posX += 1;
        }


    }

    private bool canMove(string vec)
    {

        bool vari = true;
        switch (vec)
        {
            case "w":
                if (posY + 1 > 15 || map[posX,posY + 1] == true)
                {
                    vari = false;
                }
                break;
            case "a":
                if(posX - 1 < 0 || map[posX - 1, posY] == true)
                {
                    vari = false;
                }
                break;
            case "s":
                if (posY - 1 < 0 || map[posX, posY - 1] == true)
                {
                    vari = false;
                }
                break;
            case "d":
                if (posX + 1 > 15 || map[posX + 1, posY] == true)
                {
                    vari = false;
                }
                break;
        }
        return vari;
    }
}
