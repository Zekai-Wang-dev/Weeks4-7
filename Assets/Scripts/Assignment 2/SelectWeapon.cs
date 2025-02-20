using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//This script is for the drop down menu to select a weapon type to damage the monster
public class SelectWeapon : MonoBehaviour
{

    //All the initiation of variables 
    //Dropdown menu variable
    public TMP_Dropdown dropdown;

    //The weapon game object and its sprite renderer
    public GameObject weapon;
    public SpriteRenderer weaponSR;

    //Getting the prefab 
    public GameObject prefab;
    public SpriteRenderer prefabSprite; 

    //Boolean variables to check for boss weakness match for damage
    public bool sword = true;
    public bool bow = false;
    public bool wand = false;

    //Sprite variables to change the weapon sprite based on option chosen 
    public Sprite swordSprite;
    public Sprite bowSprite;
    public Sprite wandSprite; 

    //All variables initiated in awake 
    private void Awake()
    {

        dropdown = GetComponent<TMP_Dropdown>();
        weaponSR = weapon.GetComponent<SpriteRenderer>();
        prefabSprite = prefab.GetComponent<SpriteRenderer>();
            
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Addubg a function to get and set the value changed 
        dropdown.onValueChanged.AddListener(delegate { DropDownValueChanged(); });
        
    }

    //Function to set the sprite and the boolean to which weapon is chosen 
    void DropDownValueChanged()
    {

        //Index of what weapon is selected 
        int selectedIndex = dropdown.value;

        //Selects the sword if the index is zero for the sword weakness
        if (selectedIndex == 0)
        {
            sword = true;
            bow = false;
            wand = false; 
            weaponSR.sprite = swordSprite;
            prefabSprite.sprite = swordSprite;
        }
        //Selects the bow if the index is one for the bow weakness
        else if (selectedIndex == 1)
        {
            bow = true;
            sword = false;
            wand = false; 
            weaponSR.sprite = bowSprite;
            prefabSprite.sprite = bowSprite;

        }
        //Selects the wand if the indes is two for the wand weakness
        else if(selectedIndex == 2)
        {
            wand = true;
            sword = false;
            bow = false; 
            weaponSR.sprite = wandSprite;
            prefabSprite.sprite = wandSprite;

        }
    }

}
