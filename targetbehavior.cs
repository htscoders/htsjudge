using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class targetbehavior : MonoBehaviour
{
    public int Health;
    public int MaxHealth;
    public int DamageTaken;



    // Start is called before the first frame update
    //public Text ScoreText;
    void Start()
    {
        Health = MaxHealth;
        //score = 0;\
        // F = false;
       
    
    }

    // Update is called once per frame
    void Update()
    {

        if (this.Health <= 0)
        {
            //damageable.attacking = false;
            //Destroy(self);
            WinScript.AddScore(1);
            WinScript.AddEnemy(-1);
            
            this.gameObject.SetActive(false);
            





            //enemySpawning.EnemyCount --;
            //scoreDisplay.c++;
        }
        if (WinScript.Lose == true)
        {
            this.gameObject.SetActive(false);
        }


        


    }
    void OnTriggerEnter(Collider other) 
        {
            if(other.tag == "bullet")
            {
                this.Health -= DamageTaken;
                
                

                
            }


            
        

        }
    void OnTriggerStay(Collider other)
    {
        if(other.tag == "NuclearExplosion")
        {
            this.Health -= DamageTaken;
        }
    }


}
