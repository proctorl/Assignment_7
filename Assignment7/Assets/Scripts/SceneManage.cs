using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManage : MonoBehaviour
{
   
public void MainMenu()
    {
        
        SceneManager.LoadScene("Intro");
        
    }

    public void ExitGame()
    {
        
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    
    public void ExitScene()
    {
        SceneManager.LoadScene("Exit");
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Main");

        
       
    }

    public void PlayAgain()
    {
        WordDisplay.lostScore = 0;
        WordDisplay.typedScore = 0;
        SceneManager.LoadScene("Main");
    }

  



}
