using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script is to make the health bar work by scrolling the red part to show that the player has done damage
public class HealthBar : MonoBehaviour
{

    //Initialization of all components
    public GameObject monster; 
    public MonsterProperties monsterProperties;

    public Slider healthBar;

    //Setting all components
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
        //Putting the max value of the scroll to the maximum health so that the red part covers the entire bar
        healthBar.maxValue = monsterProperties.maxHealth;

        //Set the minimum value of the scroll to zero so that the red disappears completely to show the monster is dead 
        healthBar.minValue = 0f;

        //Sets the current value of the scroll to the monster's current health so that the player knows how many health the monster has left 
        healthBar.value = monsterProperties.health; 

        
    }
}
