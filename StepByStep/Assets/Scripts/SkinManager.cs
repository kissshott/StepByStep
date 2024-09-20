using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public static int skinNum;

    public Material[] mats;

    private MeshRenderer skin;
     
    void Start()
    {
        skin = GetComponent<MeshRenderer>();

        skin.material = mats[skinNum];
        //PlayerPrefs.SetInt(skin.material.name + "equip", 1);
        //Debug.Log(skin.material.name);
    }

  
}
