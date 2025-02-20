using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public Transform transform; 

    public Transform enemyTransform;
    public Transform plrTrans;

    public GameObject plr;
    public GameObject ground;
    public GameObject enemyCollider;

    public PlayerProperties plrProperties; 

    public SpriteRenderer groundSr;
    public SpriteRenderer plrSr; 

    public float moveSpd;
    public float gravity; 

    public Vector2 velocity; 

    private void Awake()
    {
        transform = GetComponent<Transform>();
        enemyTransform = enemyCollider.GetComponent<Transform>();
        plrTrans = plr.GetComponent<Transform>();
        plrSr = plr.GetComponent<SpriteRenderer>();
        groundSr = ground.GetComponent<SpriteRenderer>();
        plrProperties = plr.GetComponent<PlayerProperties>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(velocity.x, velocity.y, 0);

        if (transform.position.x >= plrTrans.position.x - 1 )
        {

            velocity.x = -moveSpd; 

        }
        else if (transform.position.x <= plrTrans.position.x + 1)
        {

            velocity.x = moveSpd; 

        }
        else
        {
            velocity.x = 0; 
        }

        if (groundSr.bounds.Contains(enemyTransform.position))
        {

            velocity.y = 0; 

        }
        else
        {

            velocity.y -= gravity; 

        }
        
        if (plrSr.bounds.Contains(transform.position))
        {

            plrProperties.health -= 10f; 

        }
        
    }
}
