using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ballManuver : MonoBehaviour
{
    float timeElapsed = 0;
    bool pickedup=false;
    Rigidbody rb;
    private void Update()
    {
        if(pickedup)
        {
            
            timeElapsed += Time.deltaTime;
            transform.position += new Vector3(0, 2 * Time.deltaTime, 0);
            if (timeElapsed > 2)
            {
                Destroy(gameObject);
            }
        }
    }
    public void pickedUp()
    {
        rb = GetComponent<Rigidbody>();
        pickedup = true;
        rb.useGravity = false;
    }

    public TextMeshPro text;
    
    public void ShowHint()
    {
        text.text = ("Big Ball /n Very BIG /n Very nice");
    }
    public void NoShowHint()
    {
        text.text = ("");
    }
}
