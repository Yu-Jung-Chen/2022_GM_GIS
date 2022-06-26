using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpin : MonoBehaviour
{
    public float upDownSpeed;
    public float upDownRange;
    public float spinSpeed;
    float originalY;
    float offset;
    float movement;
    bool goUp=false;
    // Update is called once per frame
    private void Start()
    {
        originalY = transform.position.y;
    }
    void Update()
    {
        offset = originalY - transform.position.y;
        movement = -upDownSpeed * Time.deltaTime;
       if(offset>upDownRange)
        {
            goUp = true;
        }
       if(offset<=0)
        {
            goUp = false;
        }
       if(goUp)
        {
            movement = -1 * movement;
        }
        transform.position += new Vector3(0, movement, 0);
        transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
    }
}
