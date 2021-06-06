using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBoxIn05 : MonoBehaviour
{
    public Material m;
    public AudioSource bingGo;
    public GameObject CheckObj_05;

    public bool isPass;
    // Start is called before the first frame update
    void Start()
    {
        isPass = false;
        bingGo = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Box")
        {
            Destroy(other.gameObject);
            Destroy(CheckObj_05);
            //print("Texture/" + transform.GetComponent<MeshRenderer>().material.name + "-light");
            gameObject.GetComponent<MeshRenderer>().material = m;
            bingGo.Play();
            isPass = true;
        }
    }
}
