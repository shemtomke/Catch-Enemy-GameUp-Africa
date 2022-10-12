using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool isPlayerMove = false;
    public static bool isEnemyMove = false;
    public static bool isGameOver = false;
    public static bool isCatchEnemy = false;
    public bool isPause;

    public static float endlessScore;
    public static int collectableScore;

    public Text endlessScoreTxt;
    public Text collectableScoreTxt;

    public GameObject pausePanel;
    public GameObject inGamePanel;
    public GameObject startGamePanel; //show when opening the app - on click anywhere should start chasing the enemy

    PlayerController playerController;
    EnemyMovement enemyMovement;

    private void Start()
    {
        endlessScore = collectableScore = 0;
        playerController = FindObjectOfType<PlayerController>();
        enemyMovement = FindObjectOfType<EnemyMovement>();
    }
    private void Update()
    {
        StartGame();
        EndlessRunScore();
        CollectibleScore();
        GameOver();
        Win();
    }
    void StartGame()
    {
        //on click anywhere then start the game
        //set active the ingame panel
        //move player and enemy
    }
    void PauseGame()
    {
        //time scale
        //pause panel to active
    }
    void QuitGame()
    {
        Application.Quit();
    }
    void EndlessRunScore()
    {
        endlessScore += Time.deltaTime;
        endlessScoreTxt.text = "" + Mathf.FloorToInt(endlessScore);
    }
    void CollectibleScore()
    {
        collectableScoreTxt.text = "" + collectableScore;
    }
    
    void GameOver()
    {
        if(isGameOver)
        {
            //set is move to false - player and enemy

            //time scale to 0

            //start again game - restart
        }
    }
    void Win()
    {
        if(isCatchEnemy)
        {
            //set is move to false - player and enemy

            //time scale to 0

            //start again game - restart
        }
    }
}
