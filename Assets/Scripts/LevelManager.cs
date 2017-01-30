using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    /** Load the level**/
    public void LoadLevel(string name)
    {
        Debug.Log("scene: " + name + " loaded");
            SceneManager.LoadScene(name);  
    }

    public void QuitRequest()
    {
        Debug.Log("quit!");
        Application.Quit();
    }
}
