using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spade_Dig : MonoBehaviour
{
    bool canDig;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
        private void Update()
    {
          if(Input.GetKeyDown(KeyCode.E) && canDig == true)
          {
            animator.SetTrigger("Dig");
            animator.SetTrigger("Digging");
          }
      }
      private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            {
              canDig= true;
            }
        }

}
