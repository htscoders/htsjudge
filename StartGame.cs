using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    public static bool Gamestarted = false;
    //private int GameScene;
    // Start is called before the first frame update
    private void Start()
    {
        // GameScene = SceneManager.GetActiveScene().buildIndex - 2;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space"))
        {
            SceneManager.LoadScene("SampleScene");
            Gamestarted = true;
                
        }
    }
}
