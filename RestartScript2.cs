using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(Restart2());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Restart2()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("SampleScene");
       
    }
}
