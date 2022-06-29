using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exploadBiliding : MonoBehaviour
{
    public GameObject explosion;
    public GameObject flame;
    bool start = false;
    float timeElapsed =0;
    // Start is called before the first frame update
    private void Update()
    {
        if(start)
        {
            timeElapsed += Time.deltaTime;
            if(timeElapsed>=2)
            {  
                
                //Destroy(transform.GetChild(0).gameObject);
                
                
                deleteExplosionInstances();
            }
        }
    }

    
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        
        start = true;
        for (int i = 0; i < 20; i++)
        {
            Instantiate(explosion,transform.TransformPoint(new Vector3(0, Random.Range(0, 15), Random.Range(-14, 4))), Quaternion.identity, gameObject.transform.GetChild(0).transform);
            Instantiate(flame, transform.TransformPoint(new Vector3(0, Random.Range(0, 15), Random.Range(-14, 4))), Quaternion.identity, gameObject.transform.GetChild(1).transform);
        }
    }
    void deleteExplosionInstances()
    {
        if(transform.GetChild(0).childCount!=0)
        {
            Destroy(transform.GetChild(0).GetChild(0).gameObject);
        }
        else
        {
            start = false;
            timeElapsed = 0;
        }
        
    }
}
