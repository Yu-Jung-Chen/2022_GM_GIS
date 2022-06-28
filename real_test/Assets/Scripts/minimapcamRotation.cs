using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapcamRotation : MonoBehaviour
{
    public Transform VRCamera;
    public Transform minimapCamTrans;

    // Update is called once per frame
    void Update()
    {
        minimapCamTrans.Rotate(-VRCamera.eulerAngles.x,VRCamera.localEulerAngles.y,-VRCamera.eulerAngles.z);
    }
}
