using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_4 : MonoBehaviour
{
    public float currentHealth = Attack_4.hp;
    public RectTransform healthBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = Attack_4.hp;
        healthBar.sizeDelta = new Vector2(currentHealth,healthBar.sizeDelta.y);
    }
}
