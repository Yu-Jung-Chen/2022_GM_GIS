using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class playerController : MonoBehaviour
{
    public SteamVR_Action_Vector2 controllerInput;
    private CharacterController characterController;
    public float moveSpeed = 5f;
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        if(controllerInput.axis.magnitude>0.05f)
        {
            Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(controllerInput.axis.x, 0, controllerInput.axis.y));
            characterController.Move(1*moveSpeed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up)-new Vector3(0,9.81f,0)*Time.deltaTime);
            //transform.position += moveSpeed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up) ;

        }
        
    }
}
