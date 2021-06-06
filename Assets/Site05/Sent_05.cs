using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sent_05 : MonoBehaviour
{

    public AudioSource bingGo;
    public GameObject sentplayer;
    public GameObject sentmovepoint;
    public GameObject target;
    public Material m;
    public GameObject destination;
    public bool OnPoint;
    public bool Check_Pass;


    void Start()
    {
        Check_Pass = false;
        OnPoint = false;
        bingGo = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!target)
        {
            Check_Pass = true;
            gameObject.GetComponent<MeshRenderer>().material = m;
        }
        else 
        {
            Check_Pass = false;
        }

        if (OnPoint == true && Check_Pass == true)
        {
            Vector3 move = destination.transform.position;
            sentmovepoint.transform.position = move;
            sentplayer.transform.position = move;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == sentplayer.name)
        {
            OnPoint = true;
        }
        else
        {
            OnPoint = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == sentplayer.name)
        {
            OnPoint = false;
        }
    }
}
