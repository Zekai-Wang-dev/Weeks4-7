using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{

    public AudioClip clip;
    public AudioSource audioSource; 

    public GameObject bullet;
    public GameObject tank;

    public Transform tankTrans;


    private void Awake()
    {

        tankTrans = tank.GetComponent<Transform>();

    }
    // Start is called before the first frame update
    void Start()
    {

        audioSource.clip = clip; 
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            Instantiate(bullet, tankTrans.position, Quaternion.identity);

            audioSource.Play();


        }
        
    }
}
