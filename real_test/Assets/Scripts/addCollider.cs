using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addCollider : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Transform bigDaddy = GetComponent<Transform>();
        // Iterate through all child objects of our Geometry object
        AddCollider(bigDaddy);
       
    }
    void AddCollider(Transform target)
    {
        foreach (Transform childObject in target)
        {
            if(!childObject.GetComponent<MeshFilter>())
            {
                if (target.childCount != 0)
                {
                    for (int i = 0; i < target.childCount; i++)
                    {
                        AddCollider(target.GetChild(i).transform);
                    }
                }
            }
            else
            {
                Mesh mesh = childObject.gameObject.GetComponent<MeshFilter>().mesh;

                // If we've found a mesh we can use it to add a collider
                if (mesh != null)
                {

                    // Add a new MeshCollider to the child object
                    MeshCollider meshCollider = childObject.gameObject.AddComponent<MeshCollider>();

                    // Finaly we set the Mesh in the MeshCollider
                    meshCollider.sharedMesh = mesh;
                }
              
            }
            // First we get the Mesh attached to the child object
            

        }
    }
}