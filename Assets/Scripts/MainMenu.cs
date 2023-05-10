using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

  public Button[] levelButtons;  // Assign your level buttons in the inspector

    void Start()
    {
        // Loop through all level buttons
        for (int i = 0; i < levelButtons.Length; i++)
        {
            // If the button's level is greater than the current level, disable the button
            if (i + 1 > PlayerProgress.currentLevel)
            {
                levelButtons[i].interactable = false;
            }
        }
    }

    public void LevelOne()
    {
        SceneManager.LoadScene("Level one") ;
        
   }

      public void LevelTwo()
    {
        SceneManager.LoadScene("Level two") ;
        
   }

      public void LevelThree()
    {
        SceneManager.LoadScene("Level three") ;
        
   }



}
