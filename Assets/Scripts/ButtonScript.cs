using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void RestartButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextLevelButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MenuButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
   
}
