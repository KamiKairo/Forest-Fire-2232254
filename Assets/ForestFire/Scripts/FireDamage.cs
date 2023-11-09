using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamage : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Animal")
        {
            other.gameObject.GetComponent<Health>().isOnFire = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Animal")
        {
            other.gameObject.GetComponent<Health>().isOnFire = false;
        }
    }

}
