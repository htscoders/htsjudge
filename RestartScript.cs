using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class RestartScript : MonoBehaviour
{
    //public static bool restarted;
    public Text RestartText;

    // Start is called before the first frame update
    private void Start()
    {

        
        // PreviousSceneToLoad = SceneManager.GetActiveScene().buildIndex - 1;
        RestartText.text = (" ");
        //restarted = false;
        //StartCoroutine(LoadGame());
        
    }

    // Update is called once per frame
    void Update()
    {
        if(WinScript.Lose == true)
        {
            RestartText.text = ("Press space to restart");
            if(Input.GetKey("space"))
            {
                
                SceneManager.LoadScene("E");
                //estarted = true;
            }
        }
        if(StartGame.Gamestarted == false)
        {
            SceneManager.LoadScene("Start Menu");
        }
        
    }
    // IEnumerator LoadGame()
    // {
    //     yield return new WaitForSeconds(0.0001f)

    // }


}
