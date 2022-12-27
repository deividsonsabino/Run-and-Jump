using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float score;
    public Text scoreText;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (!playerControllerScript.gameOver)
        {
            if (playerControllerScript.doubleSpeed)
            {
                score += 2;
                scoreText.GetComponent<Text>().text = score.ToString();
            }
            else
            {
                score++;
                scoreText.GetComponent<Text>().text = score.ToString();
            }
            Debug.Log("Score: " + score);
        }
    }
}
