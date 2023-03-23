using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private IntVariable _nbStar;

    private void Start()
    {
        _nbStar._value = 0;
    }
    public void Play()
    {
        Time.timeScale = 1;
    }
    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
