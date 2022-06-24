using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class showController : MonoBehaviour
{
    public bool ControllerVisible = false;   
   
    void Update()
    {
        foreach(var hand in Player.instance.hands)
        {
            if(ControllerVisible)
            {
                hand.ShowController();
                hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithController);
            }
            else
            {
                hand.HideController();
                hand.SetSkeletonRangeOfMotion(Valve.VR.EVRSkeletalMotionRange.WithoutController);
            }
        }
    }
}
