using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{

    public Vector3 mousePos;
    public Transform transform;

    public Vector2 direction;
    public float bulletSpeed; 

    // Start is called before the first frame update
    void Start()
    {

        bulletSpeed = 0.005f;
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        direction = mousePos - transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.right = direction;

        transform.Translate(bulletSpeed, 0, 0);
        
    }
}
