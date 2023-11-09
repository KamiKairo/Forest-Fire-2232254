using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalPoints : MonoBehaviour
{
    public RescuePoints points;

    public float Bonus;

    // Start is called before the first frame update
    void Start()
    {
        points = GameObject.FindGameObjectWithTag("Player").GetComponent<RescuePoints>();


    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            points.currentRescuePoints = points.currentRescuePoints + Bonus;

            
           
            Destroy(gameObject);
            
        }
        
    }
}