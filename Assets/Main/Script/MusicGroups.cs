using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicGroups : MonoBehaviour
{
    public AudioSource[] player;
    public AudioSource[] environments;
    public AudioSource[] blocks;
    public AudioSource[] others;

    public Slider sli;
    public Dropdown dropdown;

    string select;
    //float volume;
    // Start is called before the first frame update
    void Start()
    {
        changeVoiceVulumeTo(environments);
        changeVoiceVulumeTo(player);
        changeVoiceVulumeTo(blocks);
        changeVoiceVulumeTo(others);
        //volume = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        select = dropdown.options[dropdown.value].text;
        //print(select

        switch (select)
        {
            case "Settings":
                //changeVoiceVulumeTo(volume , ?)
                //print("only settings");
                break;
            case "Main voice":
                changeVoiceVulumeTo(player);
                changeVoiceVulumeTo(environments);
                changeVoiceVulumeTo(blocks);
                changeVoiceVulumeTo(others);
                break;
            case "Player voice":
                changeVoiceVulumeTo(player);
                break;
            case "Environment voice":
                changeVoiceVulumeTo(environments);
                break;
            case "~":

                break;
        }

    }


    void changeVoiceVulumeTo(AudioSource[] ads)
    {
        foreach (AudioSource audio in ads)
        {
            audio.volume = sli.value;
        }
    }

}
