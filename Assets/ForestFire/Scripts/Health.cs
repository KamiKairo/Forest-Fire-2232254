using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Health : MonoBehaviour
{

    public int maxHealth;

    public int currentHealth;

    public int fireDamage = 5;

    public bool isOnFire;

    public float fireTimer;

    public float damageTime = 0.5f;

    public GameState gameState;




    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        

        if(isOnFire)
        {
            if(fireTimer > damageTime)
            {
                currentHealth -= fireDamage;
                fireTimer = 0;
                Debug.Log("Health: " + currentHealth);
            }
            else
            {
                fireTimer += Time.deltaTime;
            }
        }

        if (gameObject.tag == "Animal" && (currentHealth <= 0))
        {
            Destroy(gameObject);
        }
        if(gameObject.tag == "Player" && (currentHealth <= 0))
        {
            gameState.sceneToLoadTo = "EndingScreenDeath";
            gameState.StartCoroutine("FadeOutAndChnageScene");
        }

    }
}
