using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalPoints : MonoBehaviour
{
    public RescuePoints points;

    public float Bonus;

    // Start is called before the first frame update
    void Start()
    {   //gets the rescue points script
        points = GameObject.FindGameObjectWithTag("Player").GetComponent<RescuePoints>();


    }

    public void OnCollisionEnter(Collision collision)
    {   //checks if the player has collided with the animal and if it has, it will add the bonus points to the current rescue points
        if (collision.collider.tag == "Player")
        {
            points.currentRescuePoints = points.currentRescuePoints + Bonus;

            
           //once the player has collided with the animal, it will destroy the animal
            Destroy(gameObject);
            
        }
        
    }
}