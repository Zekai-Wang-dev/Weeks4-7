using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShooter : MonoBehaviour
{

    public GameObject arrows;

    public float t;

    public Transform transform;

    private void Awake()
    {

        transform = GetComponent<Transform>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime; 

        if (Mathf.CeilToInt(t)%5 == 0)
        {
            t = 0; 
            Instantiate(arrows, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);

        }

        
    }
}
