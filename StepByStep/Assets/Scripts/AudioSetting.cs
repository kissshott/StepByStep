using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AudioSetting : MonoBehaviour
{
    [SerializeField]
    private Sprite soundOn, soundOff;
    [SerializeField]
    private Sprite vibrationOn, vibrationOff;
    [SerializeField]
    private Sprite _checked, _unchecked;
    void Start()
    {
        if (PlayerPrefs.GetString("sound") == "No")
        {
            GameObject.Find("Sound").GetComponent<Image>().sprite = soundOff;
            GameObject.Find("SoundCheck").GetComponent<Image>().sprite = _unchecked;
        }
        else if (PlayerPrefs.GetString("sound") == "Yes")
        {
            GameObject.Find("Sound").GetComponent<Image>().sprite = soundOn;
            GameObject.Find("SoundCheck").GetComponent<Image>().sprite = _checked;
        }

        if (PlayerPrefs.GetString("vibration") == "No")
        {
            GameObject.Find("Vibration").GetComponent<Image>().sprite = vibrationOff;
            GameObject.Find("VibrationCheck").GetComponent<Image>().sprite = _unchecked;
        }
        else if (PlayerPrefs.GetString("vibration") == "Yes")
        {
            GameObject.Find("Vibration").GetComponent<Image>().sprite = vibrationOn;
            GameObject.Find("VibrationCheck").GetComponent<Image>().sprite = _checked;
        }
    }

    public void Sound()
    {
        if (PlayerPrefs.GetString("sound") == "No")
        {
            PlayerPrefs.SetString("sound", "Yes");
            GetComponent<Image>().sprite = soundOn;
            GameObject.Find("SoundCheck").GetComponent<Image>().sprite = _checked;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            PlayerPrefs.SetString("sound", "No");
            GameObject.Find("SoundCheck").GetComponent<Image>().sprite = _unchecked;
            GetComponent<Image>().sprite = soundOff;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    public void Vibration()
    {
        if (PlayerPrefs.GetString("vibration") == "No")
        {
            PlayerPrefs.SetString("vibration", "Yes");
            GetComponent<Image>().sprite = vibrationOn;
            GameObject.Find("VibrationCheck").GetComponent<Image>().sprite = _checked;
            Handheld.Vibrate();

        }
        else
        {
            PlayerPrefs.SetString("vibration", "No");
            GameObject.Find("VibrationCheck").GetComponent<Image>().sprite = _unchecked;
            GetComponent<Image>().sprite = vibrationOff;

        }
    }

}
