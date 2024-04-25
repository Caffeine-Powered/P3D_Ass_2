using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelShot_Behaviour : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Intobj")
        {
            Debug.Log("BallContact");
            animator.SetTrigger("Ball_Trigger");
        }
    }
}
 