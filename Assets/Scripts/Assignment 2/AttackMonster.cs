using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//This script is for clicking the attack button and getting whether or not the weakness matches in order to do damage and reduce the healthbar
public class AttackMonster : MonoBehaviour
{
    //Initialization of all components for further use 
    public GameObject weaponPrefab; 

    public GameObject monster;
    public MonsterProperties monsterProperties;

    public GameObject weapon;
    public SelectWeapon selectWeapon; 

    public GameObject monsterSpawner;
    public SpawnMonster spawnMonster; 

    public Button attackButton;

    public GameObject weakness;
    public Image weaknessSprite;

    public Sprite swordSprite;
    public Sprite bowSprite;
    public Sprite wandSprite; 

    //Boolean variables to check for the monster weakness 
    public bool swordWeak;
    public bool bowWeak;
    public bool wandWeak;

    //Variable to get a random weakness everytime player attacks
    public int ranWeak; 

    //Setting all components 
    private void Awake()
    {

        weaknessSprite = weakness.GetComponent<Image>();

        monsterProperties = monster.GetComponent<MonsterProperties>();
        spawnMonster = monsterSpawner.GetComponent<SpawnMonster>();

        selectWeapon = weapon.GetComponent<SelectWeapon>();

    }
    // Start is called before the first frame update
    void Start()
    {

        //Adding a listener to when the attack is clicked so that the player could attack the monster
        attackButton.onClick.AddListener(playerAttacked);

        //Random value to get the weakness of the monster
        ranWeak = Random.Range(0, 3);

        //Sets all the variables of the weakness and changes the sprite 
        weaknessSelected();


    }

    // Update is called once per frame
    void Update()
    {


    }

    //Function to set all variables of weakness and sprite changes after the player attacks
    void weaknessSelected()
    {

        //The monster has a sword weakness
        if (ranWeak == 0)
        {
            swordWeak = true;
            bowWeak = false;
            wandWeak = false;
            weaknessSprite.sprite = swordSprite;

        }

        //The monster has a bow weakness
        else if (ranWeak == 1)
        {
            swordWeak = false;
            bowWeak = true;
            wandWeak = false;
            weaknessSprite.sprite = bowSprite;

        }

        //The monster has a wand weakness
        else if (ranWeak == 2)
        {
            swordWeak = false;
            bowWeak = false;
            wandWeak = true;
            weaknessSprite.sprite = wandSprite;

        }
    }

    //Function for getting when the player clicks the attack button so that they could reduce the health of the monster
    void playerAttacked()
    {
        //Getting the health of the monster in variable for further use
        float health = monsterProperties.health;

        //Setting a new health so that the script doesn't accidentally change the actual health of the monster
        float newHealth = health; 

        //Checks if the monster appeared, then checks if the weapon of the player matches the weakness of the monster 
        if (spawnMonster.monsterAppear == true && (wandWeak == true && selectWeapon.wand == true) || (swordWeak == true && selectWeapon.sword == true) || (bowWeak == true && selectWeapon.bow == true))
        {

            //Reduce the health of the monster into the temp variable to be put back later into the monster's actual health 
            newHealth = health - 20f;

            //Get another random weakness after the player attacks
            ranWeak = Random.Range(0, 3);
            weaknessSelected();

            //Shoots out a clone of the weapon prefab to the monster
            Instantiate(weaponPrefab, new Vector3(9.61f, -4.96f, 0f), Quaternion.identity);

        }

        //Set the monster health to the current health after the player attacks 
        monsterProperties.health = newHealth; 


    }

}
