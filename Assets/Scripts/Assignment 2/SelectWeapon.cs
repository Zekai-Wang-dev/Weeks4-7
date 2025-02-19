using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SelectWeapon : MonoBehaviour
{

    public TMP_Dropdown dropdown;

    public GameObject weapon;
    public SpriteRenderer weaponSR; 

    public bool sword = true;
    public bool bow = false;
    public bool wand = false;

    public Sprite swordSprite;
    public Sprite bowSprite;
    public Sprite wandSprite; 

    private void Awake()
    {

        dropdown = GetComponent<TMP_Dropdown>();
        weaponSR = weapon.GetComponent<SpriteRenderer>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        dropdown.onValueChanged.AddListener(delegate { DropDownValueChanged(); });
        
    }

    void DropDownValueChanged()
    {

        int selectedIndex = dropdown.value;

        if (selectedIndex == 0)
        {
            sword = true;
            weaponSR.sprite = swordSprite; 
        }
        else if (selectedIndex == 1)
        {
            bow = true;
            weaponSR.sprite = bowSprite;

        }
        else if(selectedIndex == 2)
        {
            wand = true;
            weaponSR.sprite = wandSprite;

        }
    }

}
