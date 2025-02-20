using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeCollision : MonoBehaviour
{

    public Transform plrTrans;

    public GameObject player;
    public GameObject playerCollision;

    public PlayerProperties playerProperties;

    public SpriteRenderer spikeSr;

    public float damage; 

    private void Awake()
    {

        playerProperties = player.GetComponent<PlayerProperties>();
        spikeSr = GetComponent<SpriteRenderer>();

        plrTrans = playerCollision.GetComponent<Transform>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (spikeSr.bounds.Contains(plrTrans.position)){

            playerProperties.health -= damage; 

        }
        
    }
}
