using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    float EnemyTimer;
    public GameObject EnemyProjectile;
    public float EnemyFireRate;
    public int ProjectileSpeed;
    public float lookSpeed = 2.0f;
    public float rotation = 0;
    //public int ClusterCount;
    public static bool TripleShotActive;
    public SpriteRenderer TripleShotSprite;
    public AudioSource RocketAudio;
    public int TripleShotSpreadAngle;




    // Start is called before the first frame update
    void Start()
    {
        // Cursor.visible = false;
        TripleShotActive = false;
        this.TripleShotSprite.enabled = false;
        
    }

    

    // Update is called once per frame
    void Update()
    {

        
        if (WinScript.Lose == false)
        {
            EnemyTimer += Time.deltaTime;

                if (EnemyTimer >= EnemyFireRate * 1f)
                {
                    if (Input.GetKeyDown("space"))
                    {
                        if (TripleShotActive == true)
                        {
                            StartCoroutine(Wait());
                            EnemyTimer = 0f;
                            StartCoroutine(TripleShotExpire());
                        }
                        else
                        {
                            this.gameObject.transform.Rotate (0f, 0f, 0f);
                            GameObject EnemyBullet = Instantiate(EnemyProjectile, transform.position + new Vector3(0f,0,0f), transform.rotation) as GameObject;
                            RocketAudio.Play();
                            EnemyBullet.GetComponent<Rigidbody>().AddForce(transform.forward * ProjectileSpeed);            
                            Physics.IgnoreCollision(EnemyBullet.GetComponent<Collider>(), GetComponent<Collider>());
                            EnemyTimer = 0f;
                        }
                        
                    }


                }
        }
        if (TripleShotActive == false)
        {
            this.TripleShotSprite.enabled = false;
        }
        else{this.TripleShotSprite.enabled = true;}


            
            
    }
    IEnumerator Wait()
    {
        //for(int i = 0; i < ClusterCount; ++i)
        //{
        this.gameObject.transform.Rotate (TripleShotSpreadAngle * -1f, 0f, 0f);   
        //yield return new WaitForSeconds(0.00000001f);                     
        RocketAudio.Play();
        GameObject EnemyBullet = Instantiate(EnemyProjectile, transform.position + new Vector3(0f,0,0f), transform.rotation) as GameObject;
        EnemyBullet.GetComponent<Rigidbody>().AddForce(transform.forward * ProjectileSpeed);            
        Physics.IgnoreCollision(EnemyBullet.GetComponent<Collider>(), GetComponent<Collider>());

        this.gameObject.transform.Rotate (TripleShotSpreadAngle * 1f, 0f, 0f);
        //yield return new WaitForSeconds(0.00000001f);
        GameObject EnemyBullet2 = Instantiate(EnemyProjectile, transform.position + new Vector3(0f,0,0f), transform.rotation) as GameObject;
        EnemyBullet2.GetComponent<Rigidbody>().AddForce(transform.forward * ProjectileSpeed);            
        Physics.IgnoreCollision(EnemyBullet2.GetComponent<Collider>(), GetComponent<Collider>());

        this.gameObject.transform.Rotate (TripleShotSpreadAngle * 1f, 0f, 0f);
        //yield return new WaitForSeconds(0.00000001f);
        GameObject EnemyBullet3 = Instantiate(EnemyProjectile, transform.position + new Vector3(0f,0,0f), transform.rotation) as GameObject;
        EnemyBullet3.GetComponent<Rigidbody>().AddForce(transform.forward * ProjectileSpeed);            
        Physics.IgnoreCollision(EnemyBullet3.GetComponent<Collider>(), GetComponent<Collider>());
        yield return new WaitForSeconds(0.00000001f);
        this.gameObject.transform.Rotate (TripleShotSpreadAngle * -1f, 0f, 0f);
        

                                
                                
        //}

        
    }
    IEnumerator TripleShotExpire()
    {

        yield return new WaitForSeconds(5f);
        EnemyShooting.TripleShotActive = false;
        


                                
                                
        

        
    }
   




}
