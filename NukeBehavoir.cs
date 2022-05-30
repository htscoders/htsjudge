using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NukeBehavoir : MonoBehaviour
{
    
    public GameObject ExplosionEmission;
    public AudioSource NukeAudio;
    // public static bool E;
    // Start is called before the first frame update
    void Start()
    {
       
        // E = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NukeTrigger")
        {
        //Debug.Log("Bruh");
        GameObject NuclearExplosion = Instantiate(ExplosionEmission, transform.position + new Vector3(0f,0,0f), transform.rotation) as GameObject;
        NuclearExplosion.GetComponent<Rigidbody>().AddForce(transform.forward * 0.0001f);            
        Physics.IgnoreCollision(NuclearExplosion.GetComponent<Collider>(), GetComponent<Collider>());
        NukeAudio.Play();
        NukeSpawner.F = false;
        this.gameObject.SetActive(false);
        PanelFade.Fade = true;
        Destroy(NuclearExplosion, 4f);
        EnemySpawning.NukeSpawned = false;
        
        }
    }
//      IEnumerator Death()
//     {
//         E = true;
//         yield return new WaitForSeconds(4f);
//         E = false;
//  }
}
