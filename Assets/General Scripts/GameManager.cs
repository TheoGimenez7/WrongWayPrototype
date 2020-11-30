using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int levelsCleared=0;
    string LevelToLoad;

    public void LoadLevel(string LevelToLoad)
    {
        SceneManager.LoadScene(LevelToLoad);
    }

    public void Reset()
    {
        levelsCleared = 0;
        ItemSlot.nombrePièceOk = 0;
        StartCountdown.beginning = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    
}
