using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public InputField playerName;
    public static string ShowName;
    public Slider slider;
    public static float sliderValue;
    public Text sliderVal;
    
    
    
    

    


    void Update()
    {
        if (string.IsNullOrEmpty(playerName.text) == false)
            ShowName = playerName.text;
        else
            ShowName = "Player";
        sliderValue = slider.value;

        sliderVal.text = "Speed: " + sliderValue.ToString();

    }

    

}
