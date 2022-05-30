using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{ public static int EnemyCount;
  public int MaxEnemyCount;
  private float Minutes;
  public Text MinuteText;
  private float Seconds;
  public Text SecondText;
  private float Trueseconds;
  public Text AverageSPS;
  private float AverageSPSValue;
  public static int Score;
  public Text ScoreText;
  private float RoundedSeconds;
//   public GameObject DeleteTarget;
//   public GameObject DeleteTarget2;
  public Text LoseText;
  public GameObject LoseBackground;
  public static bool Restart;
  public int HighScoreValue;
  public static bool Lose;
  public Text HighScoreText;
//   public bool HighScoreReset;
    // Start is called before the first frame update
    void Start()
    {
        //print("Loaded WinScript");
        EnemyCount = 0;
        Lose = false;
        Minutes = 0;
        Seconds = 0;
        Score = 0;
        LoseText.text = (" ");
        LoseBackground.SetActive(false);
        HighScoreText.text = (" ");
    }

    // Update is called once per frame
    void Update()
    {

        // Debug.Log(PlayerPrefs.GetInt("HighScore"));
        PlayerPrefs.SetInt("HighScore", HighScoreValue);
        RoundedSeconds = Trueseconds;
        AverageSPSValue = Score / RoundedSeconds;
        if (EnemyCount >= MaxEnemyCount)
        {
            Lose = true;

        }
        if (Lose == false)
        {
            ScoreText.text = Score.ToString("score:") + Score;
            Trueseconds += Time.deltaTime;
            Seconds += Time.deltaTime;
            if(Seconds >= 60)
            {
                Seconds = 0;
                Minutes++;
            }
        }
        // if (HighScoreReset == true)
        // {
        //     HighScoreValue = 0;
        // }
        

        MinuteText.text = Minutes.ToString("Minutes: ") + Minutes;
        SecondText.text = Seconds.ToString("Seconds: ") + Mathf.RoundToInt(Seconds * 1f);
        AverageSPS.text = AverageSPSValue.ToString("Average score per second: ") + AverageSPSValue;
        if (Lose == true)
        {
            LoseText.text = ("L BOZO U LOST");
            LoseBackground.SetActive(true);
            // DeleteTarget.SetActive(false);
            // DeleteTarget2.SetActive(false);

            if(WinScript.Score > HighScoreValue)
            {
                HighScoreValue = WinScript.Score;
                Debug.Log("e");
                ScoreText.text = (" ");
                
            }
            HighScoreText.text = ("Highscore: ") + PlayerPrefs.GetInt("HighScore");

            
        }


        
    }
    public static void AddEnemy(int EnemyAmount)
    {
        EnemyCount += EnemyAmount;
    }
    public static void AddScore(int scoreAdded)
    {
        Score += scoreAdded;

    }

}
