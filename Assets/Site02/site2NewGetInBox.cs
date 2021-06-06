using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class site2NewGetInBox : MonoBehaviour
{
    public Material m;
    public bool isPass;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        isPass = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            Destroy(other.gameObject);
            //other.gameObject.GetComponent<BoxCollider>().isTrigger = true;
            //other.gameObject.GetComponent<MeshRenderer>().material = m;
            //print("Texture/" + transform.GetComponent<MeshRenderer>().material.name + "-light");
            gameObject.GetComponent<MeshRenderer>().material = m;
            isPass = true;
            //Debug.Log("trigger");
            door.GetComponent<BoxCollider>().isTrigger = true;
            door.layer = 0;
            door.tag = "Untagged";
            float x = door.transform.position.x;
            float y = door.transform.position.y;
            float z = door.transform.position.z;
            door.transform.position = Vector3.MoveTowards(door.transform.position, new Vector3(x, y + 1.2f, z), 2);
            //Destroy(door);
        }
    }
}
