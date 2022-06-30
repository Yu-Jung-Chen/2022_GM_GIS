using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;
using UnityEngine.Events;

public class SceneHandler : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;

    public UnityEvent onPointerClick;
    public UnityEvent onPointerInside;
    public UnityEvent onPointerOutside;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.tag == "collectableBall")
        {
            onPointerClick.Invoke();
            Debug.log("Clicked ball");
           
        }
            
    }

    public void PointerInside(object sender, PointerEventArgs e)
    {
        if(e.target.tag=="collectableBall")
        {
            onPointerInside.Invoke();
            Debug.log("in ball");
        }
        
        
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "collectableBall")
        {
            onPointerOutside.Invoke();
            Debug.log("out  ball");
        }
            
    }
}