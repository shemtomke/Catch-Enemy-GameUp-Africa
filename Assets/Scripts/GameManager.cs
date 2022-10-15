using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool isGameOver = false;
    public static bool isCatchEnemy = false;
    public bool isPause;

    public static float endlessScore;
    public static int collectableScore;

    public Text endlessScoreTxt;
    public Text collectableScoreTxt;

    public GameObject pausePanel;
    public GameObject winGamePanel;
    public GameObject gameOverPanel; //show when opening the app - on click anywhere should start chasing the enemy

    PlayerController playerController;
    EnemyMovement enemyMovement;

    private void Start()
    {
        isCatchEnemy = isGameOver = false;
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
    public void TwitterUrl()
    {
        Application.OpenURL("https://twitter.com/shemtom_games");
    }
    public void PauseGame()
    {
        //time scale
        Time.timeScale = 0;
        playerController.isPlayerMove = false;
        enemyMovement.isEnemyMove = false;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        playerController.isPlayerMove = true;
        enemyMovement.isEnemyMove = true;
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    void QuitGame()
    {
        Application.Quit();
    }
    void EndlessRunScore()
    {
        if (isCatchEnemy || isGameOver)
            return;

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
            playerController.isPlayerMove = false;
            enemyMovement.isEnemyMove = false;

            //start again game - restart
            gameOverPanel.SetActive(true);

            //restart by clicking anywhere

        }
    }
    void Win()
    {
        if(isCatchEnemy)
        {
            //set is move to false - player and enemy
            playerController.isPlayerMove = false;
            enemyMovement.isEnemyMove = false;

            //start again game - restart - when clicking again
            winGamePanel.SetActive(true);

            //restart on click anywhere
            
        }
    }
}
