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

    public static float score;

    public Text scoreTxt;

    private void Update()
    {
        Score();
    }
    void Score()
    {
        score += Time.deltaTime;
        scoreTxt.text = "" + Mathf.FloorToInt(score);
    }
    void GameOver()
    {
        if(isGameOver)
        {
            //set is move to false

        }
    }
}
