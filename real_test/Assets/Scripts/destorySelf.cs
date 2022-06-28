using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destorySelf : MonoBehaviour
{
    float lifeTime = 0;
    private void Update()
    {
        lifeTime += Time.deltaTime;
        if(lifeTime>3)
        {
            
            Destroy(gameObject);
        }
    }
}
