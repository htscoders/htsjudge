using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpBehavior : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
 


    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "bullet")
        {
            if (this.tag == "TripleShot")
            {
                EnemyShooting.TripleShotActive = true;
                this.gameObject.SetActive(false);

                other.gameObject.SetActive(false);
                
            }
            



            
            if (this.tag == "Nuke")
            {
                NukeSpawner.NukeActive = true;
                this.gameObject.SetActive(false);
                other.gameObject.SetActive(false);
                
            }
            
        }
    }


}
