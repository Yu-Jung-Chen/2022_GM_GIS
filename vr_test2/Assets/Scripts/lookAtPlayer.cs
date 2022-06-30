using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtPlayer : MonoBehaviour
{
    [SerializeField] GameObject target;
   
    void Update()
    {
        Vector3 targetPostition = new Vector3(target.transform.position.x,transform.position.y,target.transform.position.z);
        transform.LookAt(targetPostition);
        
    }
}
