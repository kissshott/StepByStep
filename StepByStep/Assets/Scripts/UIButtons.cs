using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIButtons : MonoBehaviour
{
    [SerializeField]
    private GameObject startMenu;
    [SerializeField]
    private GameObject playMenu;
    [SerializeField]
    private GameObject pauseMenu;
    [SerializeField]
    private GameObject loseMenu;
    

    

    private AudioSource ui_sound;
    private void Start()
    {
        ui_sound = GameObject.FindGameObjectWithTag("UI").GetComponent<AudioSource>();
        



       
        

    }
    public void Play()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        };
        pauseMenu.SetActive(false);
        startMenu.SetActive(false);
        playMenu.SetActive(true);
        UIControl._startMenu = true;
        Time.timeScale = 1;
        
    }
    public void Pause()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        playMenu.SetActive(false);
        pauseMenu.SetActive(true);
        UIControl._startMenu = false;
        Time.timeScale = 0;
        
    }
    public void Lose()
    {
        playMenu.SetActive(false);
        pauseMenu.SetActive(false);
        loseMenu.SetActive(true);
        UIControl._startMenu = false;
        Time.timeScale = 0;

    }
    public void Restart()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Time.timeScale = 1;
        Invoke("DelayRestart", 0.2f);
    }

    public void DelayRestart()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void Shop()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Time.timeScale = 1;
        Invoke("DelayShop", 0.2f);

    }
    public void DelayShop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void Skin()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Time.timeScale = 1;
        Invoke("DelaySkin", 0.2f);
    }
    public void DelaySkin()
    {
        SceneManager.LoadScene("Skin");
    }
    public void Settings()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Time.timeScale = 1;
        Invoke("DelaySettings", 0.2f);

    }

    public void DelaySettings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Back()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }

        Invoke("DelayBack", 0.2f);
    }
    public void DelayBack()
    {
        SceneManager.LoadScene("MainScene");
    }
    


}
