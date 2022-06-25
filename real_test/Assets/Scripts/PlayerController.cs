using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerController : MonoBehaviour
{
    public SteamVR_Action_Vector2 controllerInput;
    private CharacterController characterController;
    public float moveSpeed = 5f;
    private int onGround = 0;
    public float playerHehght;
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit raycastHit;
        if(Physics.Raycast(ray, out raycastHit))
        {
            if(raycastHit.distance<playerHehght)
            {
                onGround = 0;
            }
            else
            {
                onGround = 1;
            }
        }
        Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(controllerInput.axis.x, 0, controllerInput.axis.y));
        characterController.Move(moveSpeed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up)- onGround *new Vector3(0,9.81f,0)*Time.deltaTime);
        /*
        if (controllerInput.axis.magnitude > 0.05f)
        {
        }
        */

    }
}
