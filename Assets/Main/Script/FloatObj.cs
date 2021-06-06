using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatObj : MonoBehaviour
{
    public float freq;
    public float moveSpeed;
    public bool up;
    AudioSource getIn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("floooat", 0, freq);
        up = true;
        getIn = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (up)
        {
            gameObject.transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 1.5f, transform.position.z), Random.Range(0,.3f) * moveSpeed * Time.deltaTime);

        }
        else
        {
            gameObject.transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, .5f, transform.position.z), Random.Range(0, .3f) * moveSpeed * Time.deltaTime);
        }
    }

    void floooat()
    {
        if (gameObject.transform.position.y == .5f)
        {
            up = true;

        }
        else
        {
            up = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        getIn.Play();
    }
}
