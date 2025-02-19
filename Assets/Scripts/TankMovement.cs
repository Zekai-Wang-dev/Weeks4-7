using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankMovement : MonoBehaviour
{

    public GameObject speedUI;
    public GameObject appearanceUI;

    public Slider speedSlider;
    public Slider appearSlider; 

    public float moveSpd;
    public Transform transform;
    public float moveX;

    public SpriteRenderer sr; 

    private void Awake()
    {

        speedSlider = speedUI.GetComponent<Slider>();
        appearSlider = appearanceUI.GetComponent<Slider>();

    }
    // Start is called before the first frame update
    void Start()
    {

        moveSpd = 0.005f;

        speedSlider.maxValue = 0.01f;
        speedSlider.minValue = 0.0001f;

        appearSlider.minValue = 0;
        appearSlider.maxValue = 1; 
        
    }

    // Update is called once per frame
    void Update()
    {

        moveX = Input.GetAxis("Horizontal");

        transform.Translate(moveSpd * moveX, 0, 0);

        moveSpd = speedSlider.value; 


    }
}
