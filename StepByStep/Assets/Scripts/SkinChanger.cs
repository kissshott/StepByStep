using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkinChanger : MonoBehaviour
{
    public Sprite slot;
    public Sprite equipped;

    public Text price;
    private int price_int;
    public static List<string> skins = new List<string> { "Slot_red" };

    private AudioSource ui_sound;

    private void Start()
    {
        ui_sound = GameObject.FindGameObjectWithTag("UI").GetComponent<AudioSource>();


        
        if (skins.Contains(GetComponent<Image>().name))
        {
            PlayerPrefs.SetInt(GetComponent<Image>().name + "equip", 1);
            
        }
        else
        {
            PlayerPrefs.SetInt(GetComponent<Image>().name + "equip", 0);
            GetComponent<Image>().sprite = slot;
        }
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
                price.text = "equip";
                
            
        }
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "equip") == 1)
        {
            price.text = "equipped";
            GetComponent<Image>().sprite = equipped;
        }
       
    }
    // RED
    public void redSkin()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Invoke("DelayRed", 0.1f);
    }
    public void DelayRed()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        {
            if (PlayerPrefs.GetInt("Coins") >= int.Parse(price.text))
            {
                skins.Clear();
                skins.Add(GetComponent<Image>().name);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - int.Parse(price.text));
                PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 1);

                price.text = "equipped";
                GetComponent<Image>().sprite = equipped;
                SkinManager.skinNum = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            skins.Clear();
            skins.Add(GetComponent<Image>().name);
            price.text = "equipped";
            GetComponent<Image>().sprite = equipped;
            SkinManager.skinNum = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // MAGENTA
    public void magentaSkin()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }       
        Invoke("DelayMagenta", 0.1f);
    }
    
    public void DelayMagenta()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        {
            if (PlayerPrefs.GetInt("Coins") >= int.Parse(price.text))
            {
                skins.Clear();
                skins.Add(GetComponent<Image>().name);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - int.Parse(price.text));
                PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 1);

                price.text = "equipped";
                GetComponent<Image>().sprite = equipped;
                SkinManager.skinNum = 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            skins.Clear();
            skins.Add(GetComponent<Image>().name);
            price.text = "equipped";
            GetComponent<Image>().sprite = equipped;
            SkinManager.skinNum = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // BLUE
    public void blueSkin()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Invoke("DelayBlue", 0.1f);
    }
    public void DelayBlue()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        {
            if (PlayerPrefs.GetInt("Coins") >= int.Parse(price.text))
            {
                skins.Clear();
                skins.Add(GetComponent<Image>().name);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - int.Parse(price.text));
                PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 1);

                price.text = "equipped";
                GetComponent<Image>().sprite = equipped;
                SkinManager.skinNum = 2;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            skins.Clear();
            skins.Add(GetComponent<Image>().name);
            price.text = "equipped";
            GetComponent<Image>().sprite = equipped;
            SkinManager.skinNum = 2;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // GREEN
    public void greenSkin()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Invoke("DelayGreen", 0.1f);
    }
    public void DelayGreen()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        {
            if (PlayerPrefs.GetInt("Coins") >= int.Parse(price.text))
            {
                skins.Clear();
                skins.Add(GetComponent<Image>().name);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - int.Parse(price.text));
                PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 1);

                price.text = "equipped";
                GetComponent<Image>().sprite = equipped;
                SkinManager.skinNum = 3;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            skins.Clear();
            skins.Add(GetComponent<Image>().name);
            price.text = "equipped";
            GetComponent<Image>().sprite = equipped;
            SkinManager.skinNum = 3;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // ORANGE
    public void orangeSkin()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Invoke("DelayOrange", 0.1f);
    }
    public void DelayOrange()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        {
            if (PlayerPrefs.GetInt("Coins") >= int.Parse(price.text))
            {
                skins.Clear();
                skins.Add(GetComponent<Image>().name);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - int.Parse(price.text));
                PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 1);

                price.text = "equipped";
                GetComponent<Image>().sprite = equipped;
                SkinManager.skinNum = 4;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            skins.Clear();
            skins.Add(GetComponent<Image>().name);
            price.text = "equipped";
            GetComponent<Image>().sprite = equipped;
            SkinManager.skinNum = 4;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // JADE
    public void jadeSkin()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Invoke("DelayJade", 0.1f);
    }
    public void DelayJade()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        {
            if (PlayerPrefs.GetInt("Coins") >= int.Parse(price.text))
            {
                skins.Clear();
                skins.Add(GetComponent<Image>().name);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - int.Parse(price.text));
                PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 1);

                price.text = "equipped";
                GetComponent<Image>().sprite = equipped;
                SkinManager.skinNum = 5;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            skins.Clear();
            skins.Add(GetComponent<Image>().name);
            price.text = "equipped";
            GetComponent<Image>().sprite = equipped;
            SkinManager.skinNum = 5;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // RGB
    public void rgbSkin()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Invoke("DelayRGB", 0.1f);
    }
    public void DelayRGB()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        {
            if (PlayerPrefs.GetInt("Coins") >= int.Parse(price.text))
            {
                skins.Clear();
                skins.Add(GetComponent<Image>().name);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - int.Parse(price.text));
                PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 1);

                price.text = "equipped";
                GetComponent<Image>().sprite = equipped;
                SkinManager.skinNum = 6;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            skins.Clear();
            skins.Add(GetComponent<Image>().name);
            price.text = "equipped";
            GetComponent<Image>().sprite = equipped;
            SkinManager.skinNum = 6;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // BLUE GLOW
    public void blueGlowSkin()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Invoke("DelayBlueGlow", 0.1f);
    }
    public void DelayBlueGlow()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        {
            if (PlayerPrefs.GetInt("Coins") >= int.Parse(price.text))
            {
                skins.Clear();
                skins.Add(GetComponent<Image>().name);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - int.Parse(price.text));
                PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 1);

                price.text = "equipped";
                GetComponent<Image>().sprite = equipped;
                SkinManager.skinNum = 7;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            skins.Clear();
            skins.Add(GetComponent<Image>().name);
            price.text = "equipped";
            GetComponent<Image>().sprite = equipped;
            SkinManager.skinNum = 7;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // GREEN GLOW
    public void greenGlowSkin()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Invoke("DelayGreenGlow", 0.1f);
    }
    public void DelayGreenGlow()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        {
            if (PlayerPrefs.GetInt("Coins") >= int.Parse(price.text))
            {
                skins.Clear();
                skins.Add(GetComponent<Image>().name);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - int.Parse(price.text));
                PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 1);

                price.text = "equipped";
                GetComponent<Image>().sprite = equipped;
                SkinManager.skinNum = 8;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            skins.Clear();
            skins.Add(GetComponent<Image>().name);
            price.text = "equipped";
            GetComponent<Image>().sprite = equipped;
            SkinManager.skinNum = 8;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // BLACK GLOW
    public void blackGlowSkin()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Invoke("DelayBlackGlow", 0.1f);
    }
    public void DelayBlackGlow()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        {
            if (PlayerPrefs.GetInt("Coins") >= int.Parse(price.text))
            {
                skins.Clear();
                skins.Add(GetComponent<Image>().name);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - int.Parse(price.text));
                PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 1);

                price.text = "equipped";
                GetComponent<Image>().sprite = equipped;
                SkinManager.skinNum = 9;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            skins.Clear();
            skins.Add(GetComponent<Image>().name);
            price.text = "equipped";
            GetComponent<Image>().sprite = equipped;
            SkinManager.skinNum = 9;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // WHITE GLOW
    public void whiteGlowSkin()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Invoke("DelayWhiteGlow", 0.1f);
    }
    public void DelayWhiteGlow()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        {
            if (PlayerPrefs.GetInt("Coins") >= int.Parse(price.text))
            {
                skins.Clear();
                skins.Add(GetComponent<Image>().name);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - int.Parse(price.text));
                PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 1);

                price.text = "equipped";
                GetComponent<Image>().sprite = equipped;
                SkinManager.skinNum = 10;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            skins.Clear();
            skins.Add(GetComponent<Image>().name);
            price.text = "equipped";
            GetComponent<Image>().sprite = equipped;
            SkinManager.skinNum = 10;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // BLACK GLOW TRI
    public void blackGlowTriSkin()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Invoke("DelayBlackGlowTri", 0.1f);
    }
    public void DelayBlackGlowTri()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        {
            if (PlayerPrefs.GetInt("Coins") >= int.Parse(price.text))
            {
                skins.Clear();
                skins.Add(GetComponent<Image>().name);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - int.Parse(price.text));
                PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 1);

                price.text = "equipped";
                GetComponent<Image>().sprite = equipped;
                SkinManager.skinNum = 11;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            skins.Clear();
            skins.Add(GetComponent<Image>().name);
            price.text = "equipped";
            GetComponent<Image>().sprite = equipped;
            SkinManager.skinNum = 11;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // GREEN GLOW TRI
    public void greenGlowTriSkin()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Invoke("DelayGreenGlowTri", 0.1f);
    }
    public void DelayGreenGlowTri()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        {
            if (PlayerPrefs.GetInt("Coins") >= int.Parse(price.text))
            {
                skins.Clear();
                skins.Add(GetComponent<Image>().name);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - int.Parse(price.text));
                PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 1);

                price.text = "equipped";
                GetComponent<Image>().sprite = equipped;
                SkinManager.skinNum = 12;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            skins.Clear();
            skins.Add(GetComponent<Image>().name);
            price.text = "equipped";
            GetComponent<Image>().sprite = equipped;
            SkinManager.skinNum = 12;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    // BLUE GLOW TRI
    public void blueGlowTriSkin()
    {
        if (ui_sound)
        {
            ui_sound.Play();
        }
        Invoke("DelayBlueGlowTri", 0.1f);
    }
    public void DelayBlueGlowTri()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        {
            if (PlayerPrefs.GetInt("Coins") >= int.Parse(price.text))
            {
                skins.Clear();
                skins.Add(GetComponent<Image>().name);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - int.Parse(price.text));
                PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 1);

                price.text = "equipped";
                GetComponent<Image>().sprite = equipped;
                SkinManager.skinNum = 13;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            skins.Clear();
            skins.Add(GetComponent<Image>().name);
            price.text = "equipped";
            GetComponent<Image>().sprite = equipped;
            SkinManager.skinNum = 13;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
