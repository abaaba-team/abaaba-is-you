using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class site2NewColliderRedu : MonoBehaviour
{
    public string scene;
    public AudioSource dieVoice;

    float clock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dieVoice = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Box") || other.gameObject.CompareTag("Player"))
        {
            dieVoice.Play();

            GetComponent<Rigidbody>().Sleep();

            Invoke("scence", 1.0f);

        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box") || collision.gameObject.CompareTag("Player"))
        {
            dieVoice.Play();

            //Time.timeScale = 0f;
            GetComponent<Rigidbody>().Sleep();

            Invoke("scence", 1.0f);
            
        }
    }

    void scence()
    {
        SceneManager.LoadScene(scene);
    }
}
