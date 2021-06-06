using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonEvent : MonoBehaviour
{
    public string scene;
    public GameObject[] showOrHide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Redo()
    {
        SceneManager.LoadScene(scene);
    }

    public void Open()
    {
        foreach(GameObject obj in showOrHide)
        {
            if (obj.activeInHierarchy)
            {
                obj.SetActive(false);
            }
            else
            {
                obj.SetActive(true);
            }
        }
    }

}
