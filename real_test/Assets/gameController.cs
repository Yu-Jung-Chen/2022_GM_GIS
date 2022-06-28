using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameController : MonoBehaviour
{
    public TextMeshPro scoreText;
    public static int pickedUpScore;
    // Start is called before the first frame update
    void Start()
    {

        pickedUpScore = 0;
        scoreText.text = $"Current Score : {pickedUpScore}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addscore()
    {
        pickedUpScore++;
        scoreText.text = $"Current Score : {pickedUpScore}";
    }


       
}
