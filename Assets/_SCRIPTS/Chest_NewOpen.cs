using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Chest_NewOpen : MonoBehaviour
{
    bool canOpen;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
          if(Input.GetKeyDown(KeyCode.E) && canOpen == true)
          {
            animator.SetTrigger("Open");
          }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            {
              canOpen = true;
            }
    }
        private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
            {
                canOpen = false;
            }
    }
}
