using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playExplosion : MonoBehaviour
{
    // Start is called before the first frame update
    ParticleSystem explosion;
    float timeElapsed;
    void Start()
    {
        explosion = GetComponent<ParticleSystem>();
        timeElapsed = 0;
        explosion.Play();
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > 2)
        {
            Destroy(gameObject);
        }
    }
   
}
