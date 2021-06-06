using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDetect : MonoBehaviour
{

    public Transform player;
    public float moveSpeed = 5f;
    public Transform movePoint;

    public LayerMask blocker;

    public bool canMove;
    
    void Start()
    {
        movePoint.parent = null;
        canMove = true;
    }

    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f || Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
        {
            movePoint.position = transform.position;
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, 0.0f);

            }
            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                movePoint.position += new Vector3(0.0f, 0.0f, Input.GetAxisRaw("Vertical"));
            }


            if(Vector3.Distance(movePoint.position,player.position) == 2f && movePoint.GetComponent<hitAnnounce>().isHit == true)
            {
                canMove = false;
            }
            else
            {
                canMove = true;
            }
        }
        
        //if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
        //{
            
        //}
        
    }
}
