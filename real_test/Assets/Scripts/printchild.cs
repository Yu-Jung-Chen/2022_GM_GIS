using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class printchild : MonoBehaviour
{
    bool opening=false;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform childObject in transform)
        {
           
            Debug.Log($"{childObject}");
        }
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
