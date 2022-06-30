using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ballManuver : MonoBehaviour
{
    [SerializeField] GameObject target;
    Transform infoCanvasTransform;
    float timeElapsed = 0;
    bool pickedup=false;
    public bool lookingAtPlayer = false;
    Rigidbody rb;
    private void Start()
    {
        infoCanvasTransform=transform.GetChild(0).transform;
    }
    private void Update()
    {
        if(lookingAtPlayer)
        {
            Vector3 targetPostition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
            infoCanvasTransform.LookAt(targetPostition);
        }
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
    public void LookAtPlayer()
    {
        lookingAtPlayer = true;
    }
    public void NoLookAtPlayer()
    {
        lookingAtPlayer = false;
    }
}
