using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAct : MonoBehaviour
{
    int[] cameraplace = { 0, 0 };
    int north;
    int south;
    int east;
    int west;

    int camersize;

    public GameObject BigCam;
    public GameObject BigCamIcon;
    public GameObject WorldMap;
    public GameObject Buttons;

    private void Awake()
    {
        BigCam = GameObject.Find("worldCam");
        BigCamIcon = GameObject.Find("minimapCamAndIcon/bigmapicon");
        WorldMap = GameObject.Find("Canvas/map");
        Buttons = GameObject.Find("Canvas/worldmap");
    }

    public void camUp()
    {

    }
}
