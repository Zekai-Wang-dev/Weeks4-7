using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackMonster : MonoBehaviour
{

    public GameObject monster;
    public MonsterProperties monsterProperties;

    public GameObject monsterSpawner;
    public SpawnMonster spawnMonster; 

    public Button attackButton; 

    private void Awake()
    {

        monsterProperties = monster.GetComponent<MonsterProperties>();
        spawnMonster = monsterSpawner.GetComponent<SpawnMonster>();

    }
    // Start is called before the first frame update
    void Start()
    {
        attackButton.onClick.AddListener(playerAttacked);

    }

    // Update is called once per frame
    void Update()
    {


    }


    void playerAttacked()
    {

        float health = monsterProperties.health;

        float newHealth = health; 

        if (spawnMonster.monsterAppear == true)
        {
            newHealth = health - 20f;

        }

        monsterProperties.health = newHealth; 


    }

}
