using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterProperties : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public GameObject healthBar; 
    public GameObject monster;

    public GameObject monsterSpawner;
    public SpawnMonster spawnMonster;

    private void Awake()
    {

        spawnMonster = monsterSpawner.GetComponent<SpawnMonster>();

    }
    // Start is called before the first frame update
    void Start()
    {

        maxHealth = 100f;
        health = 100f; 

    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0f)
        {
            spawnMonster.monsterAppear = false; 

            monster.SetActive(false);
            healthBar.SetActive(false);

        }

        
    }
}
