using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowValues : MonoBehaviour
{
    
   
    
    public Text sliderValue;
    public Text pName;
    public Text Score;




    void Update()
    {
        

        Score.text = "Words Typed: " + WordDisplay.typedScore + "\n" + "Words Lost: " + WordDisplay.lostScore;
        pName.text = PlayerName.ShowName;
        sliderValue.text = "Speed: " + PlayerName.sliderValue.ToString();
    }



}
