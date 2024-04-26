using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambient_Waves : MonoBehaviour
{
        public AudioClip Waves_Crashing;
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
            gameObject.GetComponent<AudioSource>().PlayOneShot(Waves_Crashing);
        }
}
         private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            gameObject.GetComponent<AudioSource>().Stop();
        }
    }  
}