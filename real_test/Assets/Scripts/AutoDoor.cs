using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDoor : MonoBehaviour
{
    float doorPosition=0;
    public float maxOpening;
    public float mimOpening;
    public float openSpeed;
    public GameObject Ldoor;
    public GameObject Rdoor;
    bool opening = false;
    // Start is called before the first frame update
    private void Update()
    {
        if(opening)
        {  
            if(doorPosition<=maxOpening)
            {
                doorPosition += openSpeed * Time.deltaTime;
            }
        }
        else
        {
            if(doorPosition>=mimOpening)
            {
                doorPosition -= openSpeed * Time.deltaTime;
            }
        }
        Rdoor.transform.localPosition=new Vector3(-doorPosition,0,0);
        Ldoor.transform.localPosition = new Vector3(doorPosition, 0, 0);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "Player")
        {
            opening = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Player")
        {
            opening = true;
        }
    }

}
