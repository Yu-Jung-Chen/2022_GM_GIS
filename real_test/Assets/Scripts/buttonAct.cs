using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAct : MonoBehaviour
{
    int northlim;
    int southlim;
    int eastlim;
    int westlim;

    float camersize;
    float originCamSize;
    float minimapCamsize;

    public GameObject BigCam;
    public GameObject BigCamIcon;
    public GameObject WorldMap;
    public GameObject Buttons;
    public GameObject Player;

    Transform CamTransform;

    private void Awake()
    {
        BigCam = GameObject.Find("worldCam");
        BigCamIcon = GameObject.Find("minimapCamAndIcon/bigmapicon");
        WorldMap = GameObject.Find("Canvas/map");
        Buttons = GameObject.Find("Canvas/worldmap");
        CamTransform = BigCam.transform;
        originCamSize = BigCam.GetComponent<Camera>().orthographicSize;
        minimapCamsize= GameObject.Find("minimapCamAndIcon/minimap_Camera").GetComponent<Camera>().orthographicSize;
        GameObject.Find("Canvas/worldmap/OK").SetActive(false);
        GameObject.Find("Canvas/worldmap/minus").SetActive(false);
        GameObject.Find("Canvas/worldmap/up").SetActive(false);
        GameObject.Find("Canvas/worldmap/down").SetActive(false);
        GameObject.Find("Canvas/worldmap/left").SetActive(false);
        GameObject.Find("Canvas/worldmap/right").SetActive(false);
    }

    public void camUp()
    {
        CamTransform.position = new Vector3(BigCam.transform.position.x, BigCam.transform.position.y, BigCam.transform.position.z + 50);
        GameObject.Find("Canvas/worldmap/down").SetActive(true);
    }
    public void camDown()
    {
        CamTransform.position = new Vector3(BigCam.transform.position.x, BigCam.transform.position.y, BigCam.transform.position.z - 50);
        GameObject.Find("Canvas/worldmap/up").SetActive(true);
    }
    public void camLeft()
    {
         CamTransform.position = new Vector3(BigCam.transform.position.x - 50, BigCam.transform.position.y, BigCam.transform.position.z);
        GameObject.Find("Canvas/worldmap/right").SetActive(true);
    }
    public void camRight()
    {
        CamTransform.position = new Vector3(BigCam.transform.position.x + 50, BigCam.transform.position.y, BigCam.transform.position.z);
        GameObject.Find("Canvas/worldmap/left").SetActive(true);
    }

    public void plus()
    {
        BigCam.GetComponent<Camera>().orthographicSize -= minimapCamsize;
        BigCamIcon.transform.localScale -=new Vector3(5,5,0);
        GameObject.Find("Canvas/worldmap/minus").SetActive(true);
        camersize = BigCam.GetComponent<Camera>().orthographicSize;
        if (camersize <= minimapCamsize)
        {
            GameObject.Find("Canvas/worldmap/plus").SetActive(false);
            GameObject.Find("Canvas/worldmap/OK").SetActive(true);
        }

        GameObject.Find("Canvas/worldmap/up").SetActive(true);
        GameObject.Find("Canvas/worldmap/down").SetActive(true);
        GameObject.Find("Canvas/worldmap/left").SetActive(true);
        GameObject.Find("Canvas/worldmap/right").SetActive(true);
    }
    public void minus()
    {
        BigCam.GetComponent<Camera>().orthographicSize += minimapCamsize;
        BigCamIcon.transform.localScale += new Vector3(5, 5, 0);
        GameObject.Find("Canvas/worldmap/plus").SetActive(true);
        GameObject.Find("Canvas/worldmap/OK").SetActive(false);
        camersize = BigCam.GetComponent<Camera>().orthographicSize;
        if (camersize >= originCamSize)
            GameObject.Find("Canvas/worldmap/minus").SetActive(false);
    }

    public void close()
    {
        WorldMap.SetActive(false);
        Buttons.SetActive(false);
    }

    public void trans()
    {
        RaycastHit raycastHit;
        Ray ray = new Ray(BigCam.transform.position, Vector3.down);
        Physics.Raycast(ray, out raycastHit);
        Player.transform.position = BigCam.transform.position - new Vector3(0, raycastHit.distance, 0);
        WorldMap.SetActive(false);
        Buttons.SetActive(false);
    }
}
