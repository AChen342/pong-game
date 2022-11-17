using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;   // Controls whether the game is paused or not

    public GameObject pauseUserInterface; // References to a GameObject of the pause menu

    public static string theMenu = "Menu";

    // Update is called once per frame
    void Update()
    {
        // If Escape key is pressed, then the game will either pause or resume
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                ResumeGame();
            }else{
                PauseGame();
            }
        }
    }

    //Resume functionality
    public void ResumeGame(){
        FindObjectOfType<AudioManager>().Play("Click");
        pauseUserInterface.SetActive(false);    // Stops showing the pause menu
        Time.timeScale = 1f;                    // Game starts playing again
        GameIsPaused = false;
    }

    //Pause functionality
    void PauseGame(){
        FindObjectOfType<AudioManager>().Play("Click");
        pauseUserInterface.SetActive(true);    // The pause menu will appear
        Time.timeScale = 0f;                   // Stop the game time (freezes the game)
        GameIsPaused = true;
    }

    public void GoToMenu(){
        FindObjectOfType<AudioManager>().Play("Click");        
        Time.timeScale = 1f;                    // Game starts playing again
        GameIsPaused = false;
        SceneManager.LoadScene(theMenu);
    }

    public void quitGame(){
        FindObjectOfType<AudioManager>().Play("Click");      
        Debug.Log("Game Quit");
        Application.Quit();
    }
}

