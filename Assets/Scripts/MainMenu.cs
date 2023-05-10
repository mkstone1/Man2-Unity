using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
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
