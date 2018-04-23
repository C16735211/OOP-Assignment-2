using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class HighscoreController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void GoBackToMainMenu () {

        SceneManager.LoadScene("MainMenu");
    }

} // HighscoreController















