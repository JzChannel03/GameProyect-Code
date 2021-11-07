using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    public static int Score = 10;
    public string ScoreString = "Score";

    public Text TextScore;
    public static GameControler GameController;
    public Text ganaste;
    public Text gameOver;


    void Awake()
    {
        GameController = this;
        InvokeRepeating("Cronometro", 10f, 10f);
        ganaste.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TextScore != null)
        {
            TextScore.text = ScoreString + Score.ToString();
            if (Score >= 500)
            {
                ganaste.gameObject.SetActive(true);
            }

            if (Score <= 0)
            {
                gameOver.gameObject.SetActive(true);
            }
        }

        
        
    }

    void Cronometro()
    {
        Score-=5;
        TextScore.text= ScoreString + Score.ToString();
        
    }
}
