using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public GameObject monster; 
    public MonsterProperties monsterProperties;

    public Slider healthBar;


    private void Awake()
    {

        monsterProperties = monster.GetComponent<MonsterProperties>();
        healthBar = GetComponent<Slider>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        healthBar.maxValue = monsterProperties.maxHealth;
        healthBar.minValue = 0f;

        healthBar.value = monsterProperties.health; 

        
    }
}
