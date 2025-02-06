using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SelectMusic : MonoBehaviour
{

    public TMP_Dropdown dropdown;
    public AudioSource audioSource;
    public List<AudioClip> clips;
    public Slider slider; 

    private void Awake()
    {

        dropdown = GetComponent<TMP_Dropdown>();

    }

    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {

        dropdown.onValueChanged.AddListener(delegate { DropDownValueChanged(); });

        
    }

    void DropDownValueChanged()
    {

        int selectedIndex = dropdown.value; 

        audioSource.clip = clips[selectedIndex];
        audioSource.Stop();
            
    }



}
