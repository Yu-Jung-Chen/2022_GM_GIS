using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exploadBiliding : MonoBehaviour
{
    public GameObject explosion;
    public GameObject flame;
    // Start is called before the first frame update


    
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {      
        for (int i = 0; i < 20; i++)
        {
            Instantiate(explosion,transform.TransformPoint(new Vector3(0, Random.Range(0, 15), Random.Range(-14, 4))), Quaternion.identity, gameObject.transform.GetChild(0).transform);
            Instantiate(flame, transform.TransformPoint(new Vector3(0, Random.Range(0, 15), Random.Range(-14, 4))), Quaternion.identity, gameObject.transform.GetChild(1).transform);
        }
    }
}
