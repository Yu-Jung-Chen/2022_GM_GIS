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

    Transform CamTransform;

    private void Awake()
    {
        BigCam = GameObject.Find("worldCam");
        BigCamIcon = GameObject.Find("minimapCamAndIcon/bigmapicon");
        WorldMap = GameObject.Find("Canvas/map");
        Buttons = GameObject.Find("Canvas/worldmap");
        CamTransform = BigCam.transform;
    }

    public void camUp()
    {
        CamTransform.position = new Vector3(BigCam.transform.position.x + 50, BigCam.transform.position.y, BigCam.transform.position.z);
        cameraplace[0]++;
    }
    public void camDown()
    {
        CamTransform.position = new Vector3(BigCam.transform.position.x - 50, BigCam.transform.position.y, BigCam.transform.position.z);
        cameraplace[0]--;
    }
    public void camLeft()
    {
        CamTransform.position = new Vector3(BigCam.transform.position.x, BigCam.transform.position.y, BigCam.transform.position.z + 50);
        cameraplace[1]++;
    }
    public void camRight()
    {
        CamTransform.position = new Vector3(BigCam.transform.position.x, BigCam.transform.position.y, BigCam.transform.position.z - 50);
        cameraplace[1]--;
    }

    public void plus()
    {
        BigCam.GetComponent<Camera>().orthographicSize -= 50;
        BigCamIcon.transform.localScale -=new Vector3(5,5,0);
    }
    public void minus()
    {
        BigCam.GetComponent<Camera>().orthographicSize += 50;
        BigCamIcon.transform.localScale += new Vector3(5, 5, 0);
    }

    public void close()
    {
        WorldMap.SetActive(false);
        Buttons.SetActive(false);
    }
}
