using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isGamePaused = false;
    public static bool nd = false;

    [SerializeField] GameObject pauseMenu;
    public GameObject ndOptions;

    void Start(){
      pauseMenu.SetActive(false);
      ndOptions.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }

            if(ndOptions == true){
               ndOptions.SetActive(false);
               nd = false;
            }
        }
    }

    public void ResumeGame()
    {

        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

   public void Options(){
      ndOptions.SetActive(true);
      nd = true;
   }

    public void QuitGame()
    {
        Application.Quit();

        Debug.Log("Quit");
    }
}
