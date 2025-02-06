using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI; 

public class Timer : MonoBehaviour
{

    Slider slider;
    float t; 

    private void Awake()
    {

        slider = GetComponent<Slider>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        t += Time.deltaTime;
        slider.value = t % slider.maxValue; 
        
    }
}
