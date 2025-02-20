using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{

    public float t; 

    public float arrowSpd;

    public Transform transform;

    public GameObject arrow;

    public SpriteRenderer sr; 

    public Transform plrTrans;

    public GameObject plr;
    public GameObject collider; 

    public PlayerProperties plrProperties; 

    private void Awake()
    {

        plr = GameObject.Find("Player");
        sr = collider.GetComponent<SpriteRenderer>();
        plrTrans = plr.GetComponent<Transform>();
        plrProperties = plr.GetComponent<PlayerProperties>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        t += Time.deltaTime; 

        transform.Translate(-arrowSpd, 0, 0);

        if (Mathf.CeilToInt(t)%3 == 0)
        {

            Destroy(arrow);

        }

        if (sr.bounds.Contains(plrTrans.position))
        {

            plrProperties.health -= 10f;
            Destroy(arrow);

        }
        
    }
}
