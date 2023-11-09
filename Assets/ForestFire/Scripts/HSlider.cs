using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HSlider : MonoBehaviour
{

    public Slider healthSlider;

    public Image healthSliderFill;

    public Health health;

    // Start is called before the first frame update
    void Start()
    {
        healthSlider.maxValue = health.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
        healthSlider.value = health.currentHealth;

        if (health.currentHealth >= (health.maxHealth / 2))
        {
            healthSliderFill.color = Color.green;
        }
        else if (health.currentHealth >= (health.maxHealth / 4))
        {
            healthSliderFill.color = Color.yellow;
        }
        else
        {
            healthSliderFill.color = Color.red;
        }
    }
}
