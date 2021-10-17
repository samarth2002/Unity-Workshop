using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlayerMovement movement;
    public GameOver gameOver;
  

    public void EndGame()
    {
        movement.enabled = false;
        gameOver.enabled = false;
        Invoke("RestartLevel",2f);
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
    
    public void LevelComplete()
    {
        movement.enabled = false;
        gameOver.enabled = false;
        Invoke("NextLevel", 2f);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
    
    public void Quit()
    {
        Application.Quit();
    }

}
