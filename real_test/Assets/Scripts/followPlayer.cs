using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject followWho;
    GameObject vrCam;
    float turnAngel;
    private void Awake()
    {
        vrCam = followWho.transform.GetChild(0).GetChild(3).gameObject;
        

    }
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        
        transform.position = followWho.transform.position;
        //turnAngel= (followWho.transform.rotation.eulerAngles.y + vrCam.transform.localRotation.eulerAngles.y)%360;
        
        transform.rotation = Quaternion.Euler(0,vrCam.transform.rotation.eulerAngles.y, 0);

        if(Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log($"turnAngle= {turnAngel}");
            Debug.Log($"player transform rotation = {followWho.transform.rotation.eulerAngles.y}");
            Debug.Log($"vrcam transform rotation = {vrCam.transform.rotation.eulerAngles.y}");
        }

        
    }
}
