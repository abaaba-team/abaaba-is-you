using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chooseChapter : MonoBehaviour
{
    //float timer_f;
    //int timer_i;
    int flag;
    public bool canStart;

    public string chName;//传递关卡
    public int count;//传递倒计时
    public float delay;//设定显示更新间隔
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("toText", .1f, delay);
        canStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        //timer_f += Time.deltaTime;
        //timer_i = Mathf.FloorToInt(timer_f);

    }

    private void OnTriggerEnter(Collider other)
    {
        flag = 0;
        chName = other.name;
        canStart = true;
    }

    void toText()
    {
        if (canStart)
        {
            count = 5 - flag;
            flag++;
            print(count);
            if(count == 0)
            {
                switch (chName)
                {
                    case "CH1":
                        SceneManager.LoadScene("Site01");
                        break;
                    case "CH2":
                        SceneManager.LoadScene("Site02");
                        break;
                    case "CH3":
                        SceneManager.LoadScene("Site03");
                        break;
                    case "CH4":
                        SceneManager.LoadScene("Site04");
                        break;
                    case "CH5":
                        SceneManager.LoadScene("Site05");
                        break;
                    case "Operator":
                        SceneManager.LoadScene("Operator");
                        break;

                    case "LEAVE":
                        Application.Quit();
                        break;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        canStart = false;
        flag = 0;
    }
}
