using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class clickOnEnemy : MonoBehaviour
{

    public GameObject enemy; 
    public Vector3 mousePos;
    public SpriteRenderer sr;
    public TextMeshProUGUI healthUI;
    public GameObject winningScreen; 

    public float health; 

    // Start is called before the first frame update
    void Start()
    {

        health = 100f; 

    }

    // Update is called once per frame
    void Update()
    {

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        healthUI.text = health.ToString(); 

        if (Input.GetMouseButtonDown(0) && sr.bounds.Contains(mousePos))
        {

            health -= 10; 

        }

        if (health == 0)
        {

            Destroy(enemy);

        }
        
    }
}
