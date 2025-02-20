using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingLaser : MonoBehaviour
{

    public float t; 
    public Transform laserTransform;
    public Transform colliderTrans;
    public Transform playerTrans; 

    public GameObject player;
    public GameObject playerCollider; 

    public SpriteRenderer laserSr;

    public PlayerProperties playerProperties; 

    public float rotateSpd; 

    private void Awake()
    {

        playerTrans = player.GetComponent<Transform>();
        laserTransform = GetComponent<Transform>();
        colliderTrans = playerCollider.GetComponent<Transform>();
        laserSr = GetComponent<SpriteRenderer>();
        playerProperties = player.GetComponent<PlayerProperties>();

    }
    // Start is called before the first frame update
    void Start()
    {
        t = 0; 
    }

    // Update is called once per frame
    void Update()
    {

        t = rotateSpd * Time.deltaTime;

        laserTransform.Rotate(new Vector3(0, 0, t));

        if (laserSr.bounds.Contains(colliderTrans.position))
        {

            playerProperties.health -= 10; 


        }
        
    }
}
