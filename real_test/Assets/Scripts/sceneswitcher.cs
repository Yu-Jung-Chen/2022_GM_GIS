using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class sceneswitcher : MonoBehaviour
{
    public int loadLevel;
   

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(loadLevel);
    }
}
