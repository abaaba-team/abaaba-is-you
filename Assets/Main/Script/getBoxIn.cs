using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getBoxIn : MonoBehaviour
{
    public GameObject target;
    public Material m;
    public AudioSource bingGo;

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
        if(other.name == target.name)
        {
            Destroy(target);
            //print("Texture/" + transform.GetComponent<MeshRenderer>().material.name + "-light");
            gameObject.GetComponent<MeshRenderer>().material = m;
            bingGo.Play();
            isPass = true;
        }
    }
}
