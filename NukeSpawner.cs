using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NukeSpawner : MonoBehaviour
{
    public static bool NukeActive;
    public GameObject NuclearBomb;
    public int MissileSpeed;
    public bool LaunchANuke;
    public SpriteRenderer NukeSprite;
    public int NukeTimer;
    public Text NukeTimerText;
    public Text Text2;
    public static bool F;
    public AudioSource LaunchAudio;
    public AudioSource CountDown;
    // Start is called before the first frame update
    void Start()
    {
        this.NukeSprite.enabled = false;
        NukeTimer = 5;
        NukeTimerText.text = (" ");
        Text2.text = (" ");
        F = true;


    }

    // Update is called once per frame
    void Update()
    {

        if(NukeActive == true || LaunchANuke == true)
        {
            this.NukeSprite.enabled = true;
            StartCoroutine(Nuke());
            F = true;
            NukeActive = false;
            LaunchANuke = false;

        }
       
        if(F == false){
            this.NukeSprite.enabled = false;
            NukeTimerText.text = (" ");
            Text2.text = ("");
            }    
        

        

    }
    IEnumerator Nuke()
    {
        NukeTimerText.enabled = true;
        NukeTimerText.text = ("5");
        CountDown.Play();
        yield return new WaitForSeconds(1);
        NukeTimer = 5;
        // CountDown.Play();
        for(int i = 0; i < 5; ++i)
        {
            NukeTimer -= 1;
            NukeTimerText.text = NukeTimer.ToString("") + NukeTimer;
            yield return new WaitForSeconds(1);
        }
        
        if(NukeTimer <= 2)
        {
            NukeTimerText.text = ("");
            Text2.text = ("Nuke Launched!");
            GameObject Nuke = Instantiate(NuclearBomb, transform.position + new Vector3(0f,0,0f), transform.rotation) as GameObject;
            LaunchAudio.Play();
            Nuke.GetComponent<Rigidbody>().AddForce(transform.forward * MissileSpeed);
            Physics.IgnoreCollision(Nuke.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }

}
