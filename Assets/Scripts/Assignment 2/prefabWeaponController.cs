using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//This script is for controlling the prefab weapon icon that shoots out to the monster and deletes it
public class prefabWeaponController : MonoBehaviour
{

    //variable value that counts the time and acts as a timer until the variable disappears as well as change the position for lerp 
    [Range(0,1)]
    public float t;

    //Intiatiation of various components
    public SpriteRenderer sr; 
    public Transform transform;
    public GameObject prefab;

    //Setting the various components for use later
    private void Awake()
    {

        sr = GetComponent<SpriteRenderer>();
        transform = GetComponent<Transform>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Add to the time until prefab is destroyed
        t += Time.deltaTime; 

        //Lerp the position of the prefab to the monster
        transform.position = Vector3.Lerp(transform.position, new Vector3(0, 0, 0), t);

        //Destroy the prefab once the timer reaches 3 seconds so that there is no overlapping and preventing lag 
        if (t >= 3)
        {
            Destroy(prefab);
        }
        
    }
}
