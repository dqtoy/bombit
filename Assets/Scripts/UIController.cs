﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {
    public GameObject panel_shop, panel_more;
    public GameObject[] checkers;
    public Image[] blogers;
    public Button[] buttons;
    public Sprite pause_btn, unpause_btn;
    int Hovan, Vdud, Dzharahov, BigBoss, Lizzka, Druzhko, coins;
    private bool pause = false;
    

    private void Awake()
    {
        pause = false;
        
        PlayerPrefs.GetString("Volume");
        PlayerPrefs.GetInt("с", 0);
        Hovan = PlayerPrefs.GetInt("Hovan");
        Vdud = PlayerPrefs.GetInt("Vdud");
        Dzharahov = PlayerPrefs.GetInt("Dzharahov");
        BigBoss = PlayerPrefs.GetInt("BigBoss");
        Lizzka = PlayerPrefs.GetInt("Lizzka");
        Druzhko = PlayerPrefs.GetInt("Druzhko");

        PlayerPrefs.GetInt("b");
        coins = PlayerPrefs.GetInt("Coins");
        if (PlayerPrefs.GetString("Volume") == "off") {
            AudioListener.volume = 0f;
            //  Camera.main.GetComponent<AudioListener>().enabled = false;
        }
    }

  

    void Update()
    {
        Hovan = PlayerPrefs.GetInt("Hovan");
        Vdud = PlayerPrefs.GetInt("Vdud");
        Dzharahov = PlayerPrefs.GetInt("Dzharahov");
        BigBoss = PlayerPrefs.GetInt("BigBoss");
        Lizzka = PlayerPrefs.GetInt("Lizzka");
        Druzhko = PlayerPrefs.GetInt("Druzhko");

        PlayerPrefs.GetInt("b");
        coins = PlayerPrefs.GetInt("Coins");

        blogers[PlayerPrefs.GetInt("b")].color = Color.white;
        
        if (coins >= 500)
        {
            
            buttons[1].interactable = true;
            buttons[2].interactable = true;
            buttons[3].interactable = true;
            buttons[4].interactable = true;
            buttons[5].interactable = true;
            buttons[6].interactable = true;
        }
        else {
            buttons[1].interactable = false;
            buttons[2].interactable = false;
            buttons[3].interactable = false;
            buttons[4].interactable = false;
            buttons[5].interactable = false;
            buttons[6].interactable = false;
        }
        if (Hovan == 1) {
            blogers[1].color = Color.white;
            buttons[1].interactable = true;
        }
        if (Vdud == 1)
        {
            blogers[2].color = Color.white;
            buttons[2].interactable = true;
        }
        if (Dzharahov == 1)
        {
            blogers[3].color = Color.white;
            buttons[3].interactable = true;
        }
        if (BigBoss == 1)
        {
            blogers[4].color = Color.white;
            buttons[4].interactable = true;
        }
        if (Lizzka == 1)
        {
            blogers[5].color = Color.white;
            buttons[5].interactable = true;
        }
        if (Druzhko == 1)
        {
            blogers[6].color = Color.white;
            buttons[6].interactable = true;
        }

        if (panel_shop.activeSelf == true && Input.GetKeyDown(KeyCode.Escape)) {
            PlayerPrefs.SetInt("Coins", coins);
            panel_shop.SetActive(false);
        }
        
    }

    public void PlayGame()
    {
        
        SceneManager.LoadScene("Play");
    }
    public void ExitToMainMenu()
    {
        
        SceneManager.LoadScene("Main");
    }
    public void Shop() {
        panel_shop.SetActive(true);
        
    }

    public void Info()
    {
        SceneManager.LoadScene("Info");
    }
    public void CloseApp()
    {
        Application.Quit();
    }
    public void Pause()
    {
        if (pause == false)
        {
            pause = true;
            Time.timeScale = 0;
            GetComponent<Image>().sprite = unpause_btn;
        }
        else if (pause == true) {
            pause = false;
            Time.timeScale = 1;
            GetComponent<Image>().sprite = pause_btn;
        }
               
    }
        
    

    public void LoadInstaYarik()
    {
        Application.OpenURL("https://www.instagram.com/yarikzhuravlev/");
    }
    public void LoadFaceYarik()
    {
        Application.OpenURL("https://www.facebook.com/yarik.zhuravlov");
    }
    public void LoadInstaNik()
    {
        Application.OpenURL("https://www.instagram.com/vonemip/");
    }
    public void LoadPlayMarket()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.yza.bombit");
    }

    public void Close() {
        
        PlayerPrefs.SetInt("Coins", coins);
        panel_shop.SetActive(false);
    }
    
    public void blogerChanger(int bloger) {
        
        PlayerPrefs.SetInt("b",bloger);
        PlayerPrefs.Save();
        switch (bloger) {
            case 0 :

                checkers[0].SetActive(true);
                checkers[1].SetActive(false);
                checkers[2].SetActive(false);
                checkers[3].SetActive(false);
                checkers[4].SetActive(false);
                checkers[5].SetActive(false);
                checkers[6].SetActive(false);
                
                break;
            case 1 :
               if (Hovan == 0) {
                coins -= 500;
                PlayerPrefs.SetInt("Coins", coins);
                PlayerPrefs.SetInt("Hovan", 1);
                PlayerPrefs.Save();
                blogers[bloger].color = Color.white;
                    checkers[0].SetActive(false);
                    checkers[1].SetActive(true);
                    checkers[2].SetActive(false);
                    checkers[3].SetActive(false);
                    checkers[4].SetActive(false);
                    checkers[5].SetActive(false);
                    checkers[6].SetActive(false);
                }
                if (Hovan == 1) {
                    checkers[0].SetActive(false);
                    checkers[1].SetActive(true);
                    checkers[2].SetActive(false);
                    checkers[3].SetActive(false);
                    checkers[4].SetActive(false);
                    checkers[5].SetActive(false);
                    checkers[6].SetActive(false);
                }
                break;
            case 2:
                if (Vdud == 0)
                {
                    coins -= 500;
                    PlayerPrefs.SetInt("Coins", coins);
                    PlayerPrefs.SetInt("Vdud", 1);
                    PlayerPrefs.Save();
                    blogers[bloger].color = Color.white;
                    checkers[0].SetActive(false);
                    checkers[1].SetActive(false);
                    checkers[2].SetActive(true);
                    checkers[3].SetActive(false);
                    checkers[4].SetActive(false);
                    checkers[5].SetActive(false);
                    checkers[6].SetActive(false);
                }
                if (Vdud == 1)
                {
                    checkers[0].SetActive(false);
                    checkers[1].SetActive(false);
                    checkers[2].SetActive(true);
                    checkers[3].SetActive(false);
                    checkers[4].SetActive(false);
                    checkers[5].SetActive(false);
                    checkers[6].SetActive(false);
                }
                break;
            case 3:
                if (Dzharahov == 0)
                {
                    coins -= 500;
                    PlayerPrefs.SetInt("Coins", coins);
                    PlayerPrefs.SetInt("Dzharahov", 1);
                    PlayerPrefs.Save();
                    // buttons[1].gameObject.SetActive(true);
                    blogers[bloger].color = Color.white;
                    checkers[0].SetActive(false);
                    checkers[1].SetActive(false);
                    checkers[2].SetActive(false);
                    checkers[3].SetActive(true);
                    checkers[4].SetActive(false);
                    checkers[5].SetActive(false);
                    checkers[6].SetActive(false);
                }
                if (Dzharahov == 1)
                {
                    checkers[0].SetActive(false);
                    checkers[1].SetActive(false);
                    checkers[2].SetActive(false);
                    checkers[3].SetActive(true);
                    checkers[4].SetActive(false);
                    checkers[5].SetActive(false);
                    checkers[6].SetActive(false);
                }
                break;
            case 4:
                if (BigBoss == 0)
                {

                    coins -= 500;
                    PlayerPrefs.SetInt("Coins", coins);
                    PlayerPrefs.SetInt("BigBoss", 1);
                    PlayerPrefs.Save();
                    // buttons[1].gameObject.SetActive(true);
                    blogers[bloger].color = Color.white;

                    checkers[0].SetActive(false);
                    checkers[1].SetActive(false);
                    checkers[2].SetActive(false);
                    checkers[3].SetActive(false);
                    checkers[4].SetActive(true);
                    checkers[5].SetActive(false);
                    checkers[6].SetActive(false);
                }
                if (BigBoss == 1)
                {
                    checkers[0].SetActive(false);
                    checkers[1].SetActive(false);
                    checkers[2].SetActive(false);
                    checkers[3].SetActive(false);
                    checkers[4].SetActive(true);
                    checkers[5].SetActive(false);
                    checkers[6].SetActive(false);
                }
                break;
            case 5:
                if (Lizzka == 0)
                {
                    coins -= 500;
                    PlayerPrefs.SetInt("Coins", coins);
                    PlayerPrefs.SetInt("Lizzka", 1);
                    PlayerPrefs.Save();
                    // buttons[1].gameObject.SetActive(true);
                    blogers[bloger].color = Color.white;

                    checkers[0].SetActive(false);
                    checkers[1].SetActive(false);
                    checkers[2].SetActive(false);
                    checkers[3].SetActive(false);
                    checkers[4].SetActive(false);
                    checkers[5].SetActive(true);
                    checkers[6].SetActive(false);
                }
                if (Lizzka == 1)
                {
                    checkers[0].SetActive(false);
                    checkers[1].SetActive(false);
                    checkers[2].SetActive(false);
                    checkers[3].SetActive(false);
                    checkers[4].SetActive(false);
                    checkers[5].SetActive(true);
                    checkers[6].SetActive(false);
                }
                break;
            case 6:
                if (Druzhko == 0)
                {
                    coins -= 500;
                    PlayerPrefs.SetInt("Coins", coins);
                    PlayerPrefs.SetInt("Druzhko", 1);
                    PlayerPrefs.Save();
                    // buttons[1].gameObject.SetActive(true);
                    blogers[bloger].color = Color.white;

                    checkers[0].SetActive(false);
                    checkers[1].SetActive(false);
                    checkers[2].SetActive(false);
                    checkers[3].SetActive(false);
                    checkers[4].SetActive(false);
                    checkers[5].SetActive(false);
                    checkers[6].SetActive(true);
                }
                if (Druzhko == 1)
                {
                    checkers[0].SetActive(false);
                    checkers[1].SetActive(false);
                    checkers[2].SetActive(false);
                    checkers[3].SetActive(false);
                    checkers[4].SetActive(false);
                    checkers[5].SetActive(false);
                    checkers[6].SetActive(true);
                }
                break;
        }

    }
}
