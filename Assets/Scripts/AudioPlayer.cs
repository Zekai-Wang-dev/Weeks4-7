using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioPlayer : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip clip; 
    public Button startButton;
    public Button stopButton;
    public Image tape;
    public RectTransform tapeTrans;


    public bool rotating; 

    private void Awake()
    {

        audioSource = GetComponent<AudioSource>();
        tapeTrans = tape.GetComponent<RectTransform>();
 
    }

    // Start is called before the first frame update
    void Start()
    {

        startButton.onClick.AddListener(startMusic);
        stopButton.onClick.AddListener(stopMusic);
        rotating = false; 
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (rotating == true)
        {

            tapeTrans.Rotate(0, 0, 2*Time.deltaTime);

        }

        
    }

    void startMusic()
    {

        audioSource.Play();
        rotating = true; 

    }

    void stopMusic()
    {

        audioSource.Pause();
        rotating = false; 

    }

    
}
