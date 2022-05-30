using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public GameObject NewTarget;
    // public float EnemySpawnRate;
    public float timer;
    public float timerSpeed;
    public float timeToMove;
    public float DifficultyIncreaseAmount;
    public float DifficultyIncreaseSpeed;
    public float DifficultyCap;
    public GameObject PowerUp1;
    public GameObject PowerUp2;
    private float PowerUpTimer;
    public static bool NukeSpawned;
    public float PowerUpExpireSeconds;

    
      public float xPos;
      public float zPos;
      public Vector3 desiredPos;

    // Start is called before the first frame update
    void Start()
    {
      PowerUpTimer = 0;
      NukeSpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
      
      if(WinScript.Lose == false)
      {
            DifficultyIncreaseAmount += Time.deltaTime * DifficultyIncreaseSpeed;
            xPos = Random.Range(-12f, 12f);
            zPos = Random.Range(2f, 12f);
            if (timerSpeed <= DifficultyCap)
            {
              timerSpeed += (DifficultyIncreaseAmount * DifficultyIncreaseSpeed);
            }
            timer += Time.deltaTime * timerSpeed;
          if (timer >= 0)
          {


              transform.position = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * timerSpeed);
              if (Vector3.Distance(transform.position, desiredPos) <= timeToMove)
              {
                    //Debug.Log("enemy spawned");
                  desiredPos = new Vector3(xPos, transform.position.y, zPos);
                GameObject EnemyTarget = Instantiate(NewTarget, transform.position + new Vector3(0f,0f,0f), transform.rotation) as GameObject;
                WinScript.AddEnemy(1);
                  timer = 0.0f;
                  

              }
          }

      }
      PowerUpTimer += Time.deltaTime;
      if (PowerUpTimer >= 1f)
      {
        SpawnPowerUp1();
        PowerUpTimer = 0;
        SpawnPowerUp2();
      }
    void SpawnPowerUp1()
    {

        int randomNumber = Random.Range(0,20);
        if (randomNumber == 1)
        {
          GameObject TripleShot = Instantiate(PowerUp1, transform.position + new Vector3(0f,0f,0f), transform.rotation) as GameObject;
          Destroy(TripleShot, PowerUpExpireSeconds *1f);
        }
        

                                
                                
    }
    void SpawnPowerUp2()
    {
      int randomNumber = Random.Range(0,40);
      if(NukeSpawned == false)
      {
        if (randomNumber == 1)
        {
          GameObject Nuke = Instantiate(PowerUp2, transform.position + new Vector3(0f,0f,0f), transform.rotation) as GameObject;
          NukeSpawned = true;
          
        }
      }
    }

    
    }

    
}
