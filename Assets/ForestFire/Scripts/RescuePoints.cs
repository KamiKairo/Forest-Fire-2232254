using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RescuePoints : MonoBehaviour
{

    public float maxRescuePoints;
    public float currentRescuePoints;
    public TMP_Text scoreText;

    public GameState gameState;

    // Start is called before the first frame update
    void Start()
    {   //sets the start rescue points to 0
        currentRescuePoints = 0;
    }

    // Update is called once per frame
    void Update()
    {   //outputs the current rescue points to the screen
        scoreText.text = "Animals Rescued " + currentRescuePoints.ToString();
        //checks if the player has rescued 5 animals and if it has, it will change the scene to the win screen
        if (currentRescuePoints >= 5)
        {
            gameState.sceneToLoadTo = "EndingScreenWon";
            gameState.StartCoroutine("FadeOutAndChnageScene");

            scoreText.text = ("you win");
        }
    }
}
