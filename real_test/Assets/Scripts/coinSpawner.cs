using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawner : MonoBehaviour
{
    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20 ; i++)
        {
            Instantiate(coin, new Vector3(GetRandom(5), 3, GetRandom(10)), Quaternion.Euler(new Vector3(90,0,0)));
        }
    }

    // Update is called once per frame
    float GetRandom(float range)
    {
        return (Random.Range(-range, range));
    }
}
