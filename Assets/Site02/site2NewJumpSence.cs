using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class site2NewJumpSence : MonoBehaviour
{
    public site2NewGetInBox[] gbi;
    public GameObject obj;

    bool pass;

    // Start is called before the first frame update
    void Start()
    {
        pass = true;
    }

    // Update is called once per frame
    void Update()
    {
        pass = true;
        foreach (site2NewGetInBox flag in gbi)
        {
            if (!flag.isPass)
            {
                print("check: " + flag.gameObject.name);
                pass = false;
            }
        }

        if (pass)
        {
            obj.SetActive(true);
            print("pass");
        }
    }
}
