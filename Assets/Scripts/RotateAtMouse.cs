using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAtMouse : MonoBehaviour
{

    public Transform transform;
    public float rotateSpd;

    // Start is called before the first frame update
    void Start()
    {
        rotateSpd = 5f; 

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        Vector2 direction = mousePos - transform.position;

        transform.right = direction; 

        
    }
}
