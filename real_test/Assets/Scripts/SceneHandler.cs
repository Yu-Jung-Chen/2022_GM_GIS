/* SceneHandler.cs*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;

public class SceneHandler : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;

    private PointerEventData m_data=null;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.GetComponent<Button>() !=null )
        {
            var button = e.target.GetComponent<Button>();
            ExecuteEvents.Execute(EventSystem.current.currentSelectedGameObject, new PointerEventData(EventSystem.current), ExecuteEvents.submitHandler);
        }
    }
    
    public void PointerInside(object sender, PointerEventArgs e)
    {
        if (e.target.GetComponent<Button>() != null)
        {
            var button = e.target.GetComponent<Button>();
            button.Select();
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.GetComponent<Button>() != null)
        {
            var button = e.target.GetComponent<Button>();
            EventSystem.current.SetSelectedGameObject(null);
        }
    }
}