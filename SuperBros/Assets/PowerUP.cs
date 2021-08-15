using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour
{    
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
        {
            GetComponent<CharacterController2D>().Pickup();
            Destroy(this.gameObject);
        }
    }
   
}

