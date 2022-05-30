using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelFade : MonoBehaviour
{
    private float elapsedTime;
    public static bool Fade;
    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Fade == true)
        {
            elapsedTime += Time.deltaTime;
            GetComponent<CanvasGroup>().alpha = 3 * Mathf.Sin(0.75f * elapsedTime);
            //alpha = a * sin(x * time)
        }
        if(GetComponent<CanvasGroup>().alpha == 0)
        {
            elapsedTime = 0;
            Fade = false;
        }
    }


}
