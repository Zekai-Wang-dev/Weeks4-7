using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonster : MonoBehaviour
{

    public float playerPos;
    public float moveY;

    public float moveSpeed;

    public bool monsterAppear; 

    public GameObject monster;
    public GameObject healthBar;

    public MonsterProperties monsterProperties;

    private void Awake()
    {

        monsterProperties = monster.GetComponent<MonsterProperties>();

    }
    // Start is called before the first frame update
    void Start()
    {

        monsterAppear = false; 
        playerPos = 0;
        moveSpeed = 0.0005f; 

    }

    // Update is called once per frame
    void Update()
    {
        moveY = Input.GetAxis("Vertical");

        if (monsterAppear == false)
        {
            healthBar.SetActive(false);
            monster.SetActive(false);
            playerPos += moveY * moveSpeed;

        }

        if (monsterAppear == false && Mathf.CeilToInt(playerPos)%5 == 0 && playerPos != 0)
        {

            monsterAppear = true;
            healthBar.SetActive(true);

            playerPos += 1f; 

            monsterProperties.health = monsterProperties.maxHealth;

            monster.SetActive(true);

        }
        
        
    }
}
