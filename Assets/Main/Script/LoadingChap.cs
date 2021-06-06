using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingChap : MonoBehaviour
{
    int count;
    string chapName;
    bool start;
    string s;


    public chooseChapter cc;
    // Start is called before the first frame update
    void Start()
    {
        s = "";
    }

    // Update is called once per frame
    void Update()
    {
        chapName = cc.chName;
        count = cc.count;
        start = cc.canStart;
        if (start)
        {
            
            s = "Loading...\n" + chapName + "\n";
            for (int i = 0; i < 5 - count; i++)
            {
                s += "■";
            }
            for (int i = 0; i < count; i++)
            {
                s += "□";
            }

            gameObject.GetComponent<Text>().text = s;
        }
        else
        {
            gameObject.GetComponent<Text>().text = "";
        }
        
    }
}
