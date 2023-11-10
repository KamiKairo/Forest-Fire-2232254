using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RescuePoints : MonoBehaviour
{

    public float maxRescuePoints;
    public float currentRescuePoints;
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        currentRescuePoints = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Animals Rescued " + currentRescuePoints.ToString();

        if (currentRescuePoints >= 5)
        {


            scoreText.text = ("you win");
        }
    }
}
