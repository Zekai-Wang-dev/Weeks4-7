using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Transform plrTransform;
    public Transform colliderTransform; 
    public Transform groundTransform; 

    public GameObject ground; 
    public GameObject collider;

    public SpriteRenderer groundSr; 

    public float moveX;
    public float moveY;

    public Vector2 velocity; 

    public float jumpPower; 
    public float walkSpeed;

    public bool grounded;

    public float gravity; 

    private void Awake()
    {

        groundSr = ground.GetComponent<SpriteRenderer>();
        plrTransform = GetComponent<Transform>();
        colliderTransform = collider.GetComponent<Transform>();
        groundTransform = ground.GetComponent<Transform>();
        
    }


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        moveX = Input.GetAxis("Horizontal");

        plrTransform.Translate(new Vector3(moveX * walkSpeed, velocity.y, 0));

        if (grounded == false)
        {
            velocity.y -= gravity; 
        }

        if (groundSr.bounds.Contains(colliderTransform.position))
        {
            grounded = true;
            velocity.y = 0;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                velocity.y = jumpPower;
                grounded = false;

            }
        }
        else
        {
            grounded = false; 
        }

    }


}
