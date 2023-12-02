using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript : MonoBehaviour
{
   public void Pass() 
    {
        int currentlevel = SceneManager.GetActiveScene().buildIndex;
        if(currentlevel >= PlayerPrefs.GetInt("levelsUnlocked")) 
        {
            PlayerPrefs.SetInt("levelsUnlocked", currentlevel + 1);
            
        }
        Debug.Log("Level Unlocked");
    }
}
