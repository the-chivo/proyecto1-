using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class controles : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TMP_Text leftPlayer;
    [SerializeField] TMP_Text rightPlayer;
    [SerializeField] TMP_Text victoryMesage;
    [SerializeField] TMP_Text leftScore;
    [SerializeField] TMP_Text rightScore;
    [SerializeField] int winNumber = 10;
    [SerializeField] TMP_Text restartMesage;
    int lPlayer = 0;
    int rPlayer = 0;
    int lScore = 0;
    int rScore = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.A))
       {
            lPlayer += 1;
            leftPlayer.text = lPlayer.ToString();
            if(lPlayer == winNumber)
            {
                victoryMesage.text = "Player 1 win!";
                lScore += 1;
                leftScore.text = lScore.ToString();
                victoryMesage.enabled = true;
                restartMesage.enabled = true;
            }
       } 
       if(Input.GetKeyDown(KeyCode.D))
       {
            rPlayer += 1;
            rightPlayer.text = rPlayer.ToString();
            if(rPlayer == winNumber)
            {
                victoryMesage.text = "Player 2 win!";
                rScore += 1;
                rightScore.text = rScore.ToString();
                victoryMesage.enabled = true;
                restartMesage.enabled = true;
            }
       } 
       if (lPlayer >= winNumber | rPlayer >= winNumber)
       {
            if(Input.GetKeyDown(KeyCode.R))
            {
            lPlayer = 0;
            rPlayer = 0;
            leftPlayer.text = lPlayer.ToString();
            rightPlayer.text = rPlayer.ToString();
            victoryMesage.enabled = false;
            restartMesage.enabled = false;
            }

       }

    }
}
