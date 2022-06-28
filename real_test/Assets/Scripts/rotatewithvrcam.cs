using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatewithvrcam : MonoBehaviour
{
    public Transform mapCam;

    public Vector3 vrCamAngle;
    public Vector3 mapCamAngle;

    public GameObject VRCamera;

    // Start is called before the first frame update
    void Start()
    {
        VRCamera = GameObject.Find("VRCamera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
