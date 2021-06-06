using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Transform movePoint;
    public AudioSource moveVoice;

    public LayerMask blocker;
    void Start()
    {
        movePoint.parent = null;
        moveVoice = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if(Vector3.Distance(transform.position , movePoint.position) <= .05f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                Collider[] cs = Physics.OverlapSphere(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, 0.0f), 0.2f, blocker);

                if (cs.Length == 0)//&& GameObject.Find("box").GetComponent<ColliderDetect>().canMove
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, 0.0f);
                    moveVoice.Play();
                }

            }else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                Collider[] cs = Physics.OverlapSphere(movePoint.position + new Vector3(0.0f, 0.0f, Input.GetAxisRaw("Vertical")), 0.2f, blocker);
                if(cs.Length == 0)//&& GameObject.Find("box").GetComponent<ColliderDetect>().canMove
                {
                    movePoint.position += new Vector3(0.0f, 0.0f, Input.GetAxisRaw("Vertical"));
                    moveVoice.Play();
                }
            }
        }
        
    }
}
