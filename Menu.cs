using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject menuCanvas; 
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("candy"))
        {
            ShowMenu();
        }
    }


    void ShowMenu()
    {
        
        menuCanvas.SetActive(true);
       
        Time.timeScale = 0f; 
    }

    
    public void NextLevel()
    {
        Time.timeScale = 1f; 
        UnityEngine.SceneManagement.SceneManager.LoadScene("NextScene");
    }

    
    public void TryAgain()
    {
        Time.timeScale = 1f; 
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }
}