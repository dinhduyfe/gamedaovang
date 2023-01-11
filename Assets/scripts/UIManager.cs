using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text TimeOver;
    public Text addMoney;
    float TotalTime = 60;
    float RemainTime;
    float timedeltext;
    public GameObject gameOverPanel;
    public GameObject gameVictory;
    public GameObject gamePause;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timedeltext = timedeltext + Time.deltaTime;
        if (timedeltext >= 2)
        {
            addMoney.text = " ";
            timedeltext = 0;
        }
    }
    public void setScoreText(string txt)
    {
        if (scoreText)
        {
            scoreText.text = txt;
        }
    }
    public void Congdiem(string txt)
    {
        
        if (addMoney)
        {
            addMoney.text = txt;
        }
    }
    public bool setTimeOver()
    {
        
        if (TotalTime <= 0) return false;
        if (TimeOver)
        {
            TotalTime -= Time.deltaTime/2;
            RemainTime = Mathf.Round(TotalTime);
            if(RemainTime+"s" != TimeOver.text)
            {
                TimeOver.text = RemainTime + "s";
                if(RemainTime < 11) AudioManager.instance.PlaySound(AudioManager.instance.demgio, 1f);
            }
        }
        if (TotalTime > 0)
        {
            return true;
        }else
            return false;
    }

    public void ShowGameOverPanel(bool isShow)
    {
        if (gameOverPanel)
        {
            gameOverPanel.SetActive(isShow);
        }
        audioSource.Stop();
        AudioManager.instance.PlaySound(AudioManager.instance.fail, 1f);
    }

    public void ShowGameVictoryPanel(bool isShow)
    {
        if (gameVictory)
        {
            gameVictory.SetActive(isShow);
        }
        audioSource.Stop();
        AudioManager.instance.PlaySound(AudioManager.instance.win, 1f);
    }
    public void ShowPauseGamePanel(bool isShow)
    {
        if (gamePause)
        {
            gamePause.SetActive(isShow);
        }
    }
}
