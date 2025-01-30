using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledDissabled : MonoBehaviour
{

    public GameObject go; 
    public SpriteRenderer sr;
    public EnabledDissabled script;
    public AudioSource audioSource;
    public AudioClip clip; 

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            //sr.enabled = false;
            //script.enabled = false;
            go.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            //sr.enabled = true; 
            //script.enabled = true;
            go.SetActive(true);

        }

        if (Input.GetKey(KeyCode.Space))
        {

            //audioSource.Play();
            if (audioSource.isPlaying == false)
            {
                audioSource.PlayOneShot(clip);

            }

        }
        
    }
}
