using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    [SerializeField]
    private GameObject startMenu;
    [SerializeField]
    private GameObject playMenu;
    [SerializeField]
    private GameObject pauseMenu;
    [SerializeField]
    private GameObject loseMenu;
    public static bool _startMenu;
    [Header("Tags")]
    [Tooltip("Unique Object Tag")]
    [SerializeField] private string createdTag;
    void Awake()
    {
        GameObject obj = GameObject.FindWithTag(this.createdTag);
        if (obj != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            this.gameObject.tag = this.createdTag;
            DontDestroyOnLoad(this.gameObject);
        }
        PlayerPrefs.SetString("sound", "Yes");
        PlayerPrefs.SetString("vibration", "Yes");
        startMenu.SetActive(true);
        _startMenu = false;
    }
   

}
