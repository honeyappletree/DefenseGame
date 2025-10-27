using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class StopGame : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private GameObject pausePanel;
    private bool pause = false;
    private bool resume = false;
    private bool quit = false;
    private bool retry = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        if(pause == false)
        {
            Pause();
        }
        else if(resume == false)
        {
            Resume();
        }
        else if(retry == false)
        {
            Retry();
        }
        else if(quit == false)
        {
            QuitGame();
        }
    }

    public void Pause()
    {
        pause = true;
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void Resume()
    {
        resume = true;
        pause = false;
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        resume = false;
        Debug.Log(resume);
    }

    public void Retry()
    {
        retry = true;
        pause = false;
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        SceneManager.LoadScene("SampleScene");
        retry = false;
    }

    public void QuitGame()
    {
        quit = true;
        pause = false;
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        SceneManager.LoadScene("StartScene");
        quit = false;
    }
}
