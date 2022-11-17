using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static string easyMode = "PongEasy";
    public static string normalMode = "PongNormal";
    public static string hardMode = "PongHard";
    public static string DMMode = "PongDM";
    public GameObject difficultyPanel;
    public GameObject mainMenuPanel;
    public void toSelectDifficulty()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        mainMenuPanel.SetActive(false);
        difficultyPanel.SetActive(true);
    }

    public void toMainMenu()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        mainMenuPanel.SetActive(true);
        difficultyPanel.SetActive(false);
    }

    // Different Modes
    public void toEasyMode()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene(easyMode);
    }

    public void toNormalMode()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene(normalMode);
    }

    public void toHardMode()
    {
        FindObjectOfType<AudioManager>().Play("Click");      
        SceneManager.LoadScene(hardMode);
    }

    public void toDMMode()
    {
        FindObjectOfType<AudioManager>().Play("Click");      
        SceneManager.LoadScene(DMMode);
    }

    public void quitGame(){
        FindObjectOfType<AudioManager>().Play("Click");
        Debug.Log("Game Quit");
        Application.Quit();
    }
}
