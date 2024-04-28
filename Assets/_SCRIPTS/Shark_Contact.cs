using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark_Contact : MonoBehaviour
{
    public ParticleSystem blood;
    public AudioClip chomp;


void OnTriggerEnter (Collider other)
{
    if(other.tag == "Player")
    {
        blood.Play();
        gameObject.GetComponent<AudioSource>().PlayOneShot(chomp);
    }
}
}