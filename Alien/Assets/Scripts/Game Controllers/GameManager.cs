using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    [HideInInspector]
    public bool gameStartedFromMainMenu, gameRestartedAfterPlayerDied;

    [HideInInspector]
    public int score, coinScore, lifeSCore;

    void Awake () {
        MakeSingleton ();
    }



    // Carries instance of GameManager through each scene
    // Destroys any duplicates of GameManager also using Singleton Pattern

    void MakeSingleton () {
        if (instance != null) { 
            Destroy (gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad (gameObject);
        }
      
    }

} // GameManager
