using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class showBallInfo : MonoBehaviour
{

    public TextMeshPro text;
    // Start is called before the first frame update
    public void ShowHint()
    {
        text.text = ("Big Ball /n Very BIG /n Very nice");
    }
    public void NoShowHint()
    {
        text.text = ("");
    }


}
