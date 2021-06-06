using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Attack_4 : MonoBehaviour
{
    public static float hp = 6.0f;
    private AudioSource playerAudio;
    public AudioClip attack;
    public AudioClip Victory;
    public GameObject enemy;
    static public bool iswin=false;
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp == 0)
        {        
            Destroy(enemy);
            iswin = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Box")
        {
            
            
            playerAudio.PlayOneShot(attack, 0.5f);
            Destroy(other.gameObject,0.1f);
            enemy.GetComponent<NavMeshAgent>().speed += 1;
            hp -= 1;
            
            if(hp==0)
                playerAudio.PlayOneShot(Victory, 0.5f);
        }
    }
   
}
