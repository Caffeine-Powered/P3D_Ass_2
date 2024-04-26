using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Chest_NewOpen : MonoBehaviour
{
    bool used;
    bool canOpen;
    public Animator animator;
    public GameObject Chest_text;
    // Start is called before the first frame update
    void Start()
    {
        used = false;
        Chest_text.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
      if(used == false){
          if(Input.GetKeyDown(KeyCode.E) && canOpen == true)
          {
            animator.SetTrigger("Open");
            Chest_text.SetActive(false);
            used = true;
          }
      }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            {
              canOpen = true;
            if(used == false)
              {
                Chest_text.SetActive(true);
              }
            else
            {
                Chest_text.SetActive(false);
            }
            }
    }
        private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
            {
                canOpen = false;
                Chest_text.SetActive(false);
            }
    }
}
