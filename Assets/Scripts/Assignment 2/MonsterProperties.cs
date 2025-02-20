using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//This script is to get all the monster properties to determine whether or not it dies from the player 
public class MonsterProperties : MonoBehaviour
{

    //All components are initialized here
    public float health;
    public float maxHealth;

    public GameObject healthBar; 
    public GameObject monster;

    public GameObject monsterSpawner;
    public SpawnMonster spawnMonster;

    //Initialize all components
    private void Awake()
    {

        spawnMonster = monsterSpawner.GetComponent<SpawnMonster>();

    }
    // Start is called before the first frame update
    void Start()
    {
        //Setting the monster's health to its maximum health so that it could appear
        maxHealth = 100f;
        health = 100f; 

    }

    // Update is called once per frame
    void Update()
    {

        //Once the monster dies, make it disappear along with its health bar and weakness so that the player knows it dies 
        if (health <= 0f)
        {
            spawnMonster.monsterAppear = false; 

            monster.SetActive(false);
            healthBar.SetActive(false);

        }

        
    }
}
