using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollList : MonoBehaviour
{
    float posX;
    float posY;
    float posZ;

    public float scrollHeight;
    public float maxDistanceDelta;
    // Start is called before the first frame update
    void Start()
    {
        posX = gameObject.transform.position.x;
        posY = gameObject.transform.position.y;
        posZ = gameObject.transform.position.z;
        scrollHeight = Screen.height / 424 * scrollHeight;
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(posX, posY + scrollHeight + 300, posZ),maxDistanceDelta);

        if(gameObject.transform.position.y >= posY + scrollHeight + 200)
        {
            gameObject.transform.position = new Vector3(posX, posY, posZ);
        }
    }
}
