using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_Behaviour : MonoBehaviour

{
    bool canShoot;
    public Animator animator;
    public AudioClip CannonShot;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
          if(Input.GetKeyDown(KeyCode.E) && canShoot == true)
          {
            animator.SetTrigger("Cannon_Fire");

            gameObject.GetComponent<AudioSource>().PlayOneShot(CannonShot);
          }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            {
              canShoot = true;
            }
    }
        private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
            {
                canShoot = false;
            }
    }
}
