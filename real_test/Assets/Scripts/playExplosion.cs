using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playExplosion : MonoBehaviour
{
    // Start is called before the first frame update
    ParticleSystem explosion;
    void Start()
    {
        explosion = GetComponent<ParticleSystem>();
        explosion.Play();
    }

    // Update is called once per frame
    
   
}
