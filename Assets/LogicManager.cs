using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.FilePathAttribute;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    public int moves;
    public bool gamemode1;
    public bool gamemode2;
    public bool gamemode3;
    public bool catOnStars = false;

    public Text movesText;

    public WinScript WinScript;
    public WinScript2 WinScript2;
    public RealCat Cat1;
    public RealCat2 Cat2;
    public Star1Script Star1Script;
    public Star2Script Star2Script;

    public GameObject star1;
    public GameObject star2;
    public GameObject win1;
    public GameObject win2;
    public GameObject gameWonScreen;
    public GameObject gamemodeButtons;
    public GameObject gameM1;
    public GameObject gameM2;
    public GameObject gameM3;


    [ContextMenu("Increase Moves")]
    public void addMoves()
    {
        moves = moves + 1;
        movesText.text = moves.ToString();
    }
    public void gameWon()
    {
        if (WinScript.RedWin && WinScript2.BlueWin)
        {
            gameWonScreen.SetActive(true);
            Cat1.catIsAlive = false;
            Cat2.catIsAlive = false;
        }
    }
    public void onStars()
    {
        if (Star1Script.star1 && Star2Script.star2)
        {
            win1.SetActive(true);
            win2.SetActive(true);
            star1.SetActive(false);
            star2.SetActive(false);
        }
    }
    public void G1()
    {
        gamemode1 = true;
        gamemode2 = false;
        gamemode3 = false;
        gameM1.SetActive(true);
        gamemodeButtons.SetActive(false);
    }
    public void G2()
    {
        gamemode1 = false;
        gamemode2 = true;
        gamemode3 = false;
        gameM2.SetActive(true);
        gamemodeButtons.SetActive(false);
    }
    public void G3()
    {
        gamemode1 = false;
        gamemode2 = false;
        gamemode3 = true;
        gameM3.SetActive(true);
        gamemodeButtons.SetActive(false);
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
