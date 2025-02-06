using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioSlider : MonoBehaviour
{

    public Slider slider;
    public GameObject audioPlayer;
    public AudioSource audioSource;

    public AudioClip clip; 

    private void Awake()
    {

        slider = GetComponent<Slider>();
        audioSource = audioPlayer.GetComponent<AudioSource>();
        clip = audioSource.clip; 

    }

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        clip = audioSource.clip; 
        slider.maxValue = clip.length; 
        slider.value = audioSource.time % slider.maxValue; 

        
    }
}
