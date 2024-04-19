using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tavern_Audio : MonoBehaviour
{
    public AudioClip WaterSplash;
    
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
        }
    }
}
