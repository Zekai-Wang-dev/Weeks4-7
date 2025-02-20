using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//This script is for spawning the monster after the player walks a certain distance or making it disappear after it dies, it is not a prefab 
public class SpawnMonster : MonoBehaviour
{
    //All component varaibles in initialized here. 
    public float playerPos;
    public float moveY;

    public float moveSpeed;

    public bool monsterAppear;

    public TextMeshProUGUI distance; 

    public GameObject monster;
    public GameObject healthBar;

    public MonsterProperties monsterProperties;

    //Setting the component variables for further use 
    private void Awake()
    {

        monsterProperties = monster.GetComponent<MonsterProperties>();

    }
    // Start is called before the first frame update
    void Start()
    {

        //Have the monster not appear at the start so that the player could walk a distance first 
        monsterAppear = false; 
        playerPos = 0;
        moveSpeed = 0.0005f; 

    }

    // Update is called once per frame
    void Update()
    {

        //Get the input for w and s on the keyboard
        moveY = Input.GetAxis("Vertical");

        //Get the distance shown on the screen so that the player knows if they are moving forward/backward
        distance.text = "Distance: " + playerPos + "m";

        //Make the monster disappear if it is not supposed to appear or if it dies, also allows player to move. 
        if (monsterAppear == false)
        {
            healthBar.SetActive(false);
            monster.SetActive(false);
            playerPos += moveY * moveSpeed;

        }

        //Once the player reaches a certain point, a monster would spawn and it will show its weakness as well as health bar so that the player could kill it
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
