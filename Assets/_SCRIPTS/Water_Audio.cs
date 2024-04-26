using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Water_Audio : MonoBehaviour
{
    public AudioClip WaterSplash;
    public PostProcessVolume volume; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(WaterSplash);
            volume.enabled = true;
        }
    }
          private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
        volume.enabled = false;
        }
    }  
 
}
