using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamage : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {    //checks if the player/animal is in the fire and if it is, it will start damaging the player/animal
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Animal")
        {
            other.gameObject.GetComponent<Health>().isOnFire = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {   //checks if the player/animal is still in the fire and if it is not, it will stop damaging the player/animal
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Animal")
        {
            other.gameObject.GetComponent<Health>().isOnFire = false;
        }
    }

}
