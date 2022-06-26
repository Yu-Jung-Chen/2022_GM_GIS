using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destorySelf : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision");
        Destroy(gameObject);
    }
}
