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
        turnAngel= followWho.transform.rotation.y + vrCam.transform.rotation.y;

        transform.rotation = Quaternion.EulerAngles(0, turnAngel, 0);
        
    }
}
