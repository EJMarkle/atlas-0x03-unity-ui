using UnityEngine;
using UnityEngine.SceneManagement;

/// Main menu methods
public class MainMenu : MonoBehaviour
{  
    // starts maze scene
    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");
    }

    // quits application
    public void QuitMaze()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
