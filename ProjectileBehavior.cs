using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{

    public GameObject Explosion;
    public GameObject ExplosionCollider;
    public AudioSource ExplosionAudio;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            GameObject ExplosionArea = Instantiate(Explosion, transform.position + new Vector3(0f,0,0f), transform.rotation) as GameObject;
            GameObject ExplosionAreaCollider = Instantiate(ExplosionCollider, transform.position + new Vector3(0f,0,0f), transform.rotation) as GameObject;
            ExplosionAreaCollider.GetComponent<Rigidbody>().AddForce(transform.forward * 0.00001f);
            ExplosionAudio.Play();
            Destroy(ExplosionAreaCollider, 0.1f);
            Destroy(ExplosionArea, 1f);
            this.gameObject.SetActive(false);

        }
    }

}
