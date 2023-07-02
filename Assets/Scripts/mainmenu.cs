using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("level1");//load the level one
    }
    public void QuitGame()
    {
        Application.Quit();//quit game
    }
}
