using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("References")]
    //Game Over Canvas that is used for the game
    public GameObject gameOverCanvas;

    //Score Canvas that is used for the game
    public GameObject scoreCanvas;

    //Spawner object that is used for the game
    public GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        //Speed for the game is at a playing state
        Time.timeScale = 1;
        //Score is visible
        scoreCanvas.SetActive(true);
        //Game Over UI is invisible
        gameOverCanvas.SetActive(false);
        //The spawner is showed in the game
        spawner.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
