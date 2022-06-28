using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapcamRotation : MonoBehaviour
{
    public Transform VRCamera;
    public GameObject minimapCamera;
    public Transform minimapCamTrans;

    // Start is called before the first frame update
    void Start()
    {
        minimapCamTrans = minimapCamera.transform;
    }

    // Update is called once per frame
    void Update()
    {
        minimapCamTrans.localEulerAngles.x = -VRCamera.eulerAngles.x;
        minimapCamTrans.localEulerAngles.z = -VRCamera.eulerAngles.z;
    }
}
