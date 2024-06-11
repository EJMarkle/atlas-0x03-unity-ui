using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// Main menu methods
public class MainMenu : MonoBehaviour
{  
    public Material trapMat;
    public Material goalMat;
    public Toggle colorblindMode;
    private Color normalTrapColor;
    private Color normalGoalColor;


    void Start()
    {
        normalTrapColor = trapMat.color;
        normalGoalColor = goalMat.color;

        colorblindMode.isOn = false;
    }

    // starts maze scene
    public void PlayMaze()
    {
        if (colorblindMode.isOn)
        {
            trapMat.color = new Color32(255, 112, 0, 1);
            goalMat.color = Color.blue;
        }
        else
        {
            trapMat.color = normalTrapColor;
            goalMat.color = normalGoalColor;
        }

        SceneManager.LoadScene("maze");
    }

    // quits application
    public void QuitMaze()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
