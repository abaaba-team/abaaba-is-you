using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class enemy_move_4 : MonoBehaviour
{
    public NavMeshAgent enemy;
    public GameObject Player;
    private AudioSource playerAudio;
    public AudioClip gameovear;
    static public bool isdead=false;
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        enemy.SetDestination(Player.transform.position);
    }
 
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.name == "Player") {
            playerAudio.PlayOneShot(gameovear, 0.5f);
            isdead = true;
            Destroy(other.gameObject.GetComponent<MeshRenderer>());
            return;
        }

    }
}
