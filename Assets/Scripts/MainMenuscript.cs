using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuscript : MonoBehaviour
{
    public void PlayButton(){
        SceneManager.LoadScene("PlayScene");
    }
    public void TutorialButton(){
        SceneManager.LoadScene("TutorialScene");
    }
    public void AboutButton(){
        SceneManager.LoadScene("AboutScene");
    }
    
}
