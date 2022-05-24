using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogScript : MonoBehaviour
{
    public TextMeshProUGUI simpleUIText; 

    public void OnThumbsUpRight(){
        simpleUIText.text = "OnThumbsUpRight";
    }

    public void OnThumbsUpLeft(){
        simpleUIText.text = "OnThumbsUpLeft";
    }

    public void OnThumbsDownRight(){
        simpleUIText.text = "OnThumbsDownRight";
    }

    public void OnThumbsDownLeft(){
        simpleUIText.text = "OnThumbsDownLeft";
    }
}
