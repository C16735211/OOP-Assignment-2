using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public void StartGame()
    {
        GameManager.instance.gameStartedFromMainMenu = true;
        SceneManager.LoadScene("Gameplay");
    }

    public void HighscoreMenu()
    {
        SceneManager.LoadScene("HighscoreScene");
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MusicButton()
    {

    }

} // MainMenuController

































