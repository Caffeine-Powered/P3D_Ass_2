using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest_Open : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    animator.SetTrigger("Open");
                    Debug.Log("E pressed");
                }

            }
    }
}
