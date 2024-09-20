using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudiControl : MonoBehaviour
{
    public GameObject SFX;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("sound") != "No")
        {
            SFX.gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetString("sound") == "No")
        {
            SFX.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
  
}
