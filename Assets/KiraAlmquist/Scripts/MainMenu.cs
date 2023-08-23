using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public string sceneToLoad;


    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    // Update is called once per frame
    public void ExitGame()
    {
        Debug.Log("Application Quit!");
        Application.Quit();
        
    }
}
