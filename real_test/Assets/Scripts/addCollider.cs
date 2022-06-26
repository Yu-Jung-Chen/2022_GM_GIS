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
        if (!target.GetComponent<MeshFilter>())
        {
            foreach (Transform childObject in target)
            {
                AddCollider(childObject.transform);
            }
        }
        else
        {
            Mesh mesh = target.gameObject.GetComponent<MeshFilter>().mesh;

            // If we've found a mesh we can use it to add a collider
            if (mesh != null)
            {

                // Add a new MeshCollider to the child object
                MeshCollider meshCollider = target.gameObject.AddComponent<MeshCollider>();

                // Finaly we set the Mesh in the MeshCollider
                meshCollider.sharedMesh = mesh;
            }

        }
    }
}