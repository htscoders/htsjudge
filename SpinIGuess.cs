using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinIGuess : MonoBehaviour
{
    public float spinspeed;
    public bool IdkWhatToCallThisVariable;
    //public float SpinTimer;
    //public float SpinTimerMax;
    //public float CorrectionFactor;
    //     public float lookSpeed = 2.0f;
    // public float rotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        // SpinTimer = 0;
        IdkWhatToCallThisVariable = false;
        StartCoroutine(Spin());
    }

    // Update is called once per frame
    void Update()
    {
        if(WinScript.Lose == false)
        {
            //SpinTimer += Time.deltaTime;
            // if(SpinTimer < SpinTimerMax * 0.01 * CorrectionFactor)
            // {
            //     transform.Rotate(Vector3.right * spinspeed * Time.deltaTime);
            // }
            // if(this.gameObject.transform.eulerAngles.y >= 60)
            // {
            //     IdkWhatToCallThisVariable = true;
            //     Debug.Log("e");
            // }
            // if(SpinTimer > 0)
            // {
            //     transform.Rotate(Vector3.left * spinspeed * Time.deltaTime);
            // }
            // if(this.gameObject.transform.eulerAngles.y <= -60)
            // {
            //     IdkWhatToCallThisVariable = false;
            // }

            if(IdkWhatToCallThisVariable == true)
            {
                transform.Rotate(Vector3.right * spinspeed);
            }
            if(IdkWhatToCallThisVariable == false)
            {
                transform.Rotate(Vector3.left * spinspeed);
            }
            // if(SpinTimer >= SpinTimerMax)
            // {
            //     SpinTimer = 0 - SpinTimerMax;
            // }
                //         rotation += -Input.GetAxis("Mouse X") * lookSpeed;
                // //rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
                // //playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
                       
                // transform.rotation *= Quaternion.Euler(Input.GetAxis("Mouse X") * lookSpeed, 0, 0);
        }


    }
    IEnumerator Spin(){
     while(true){
        IdkWhatToCallThisVariable = false;
        yield return new WaitForSeconds(1.588f);
        IdkWhatToCallThisVariable = true;
        yield return new WaitForSeconds(1.6f);
     }
 }
}
