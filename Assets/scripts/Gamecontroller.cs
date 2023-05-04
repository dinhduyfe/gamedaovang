using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamecontroller : MonoBehaviour
{

    public GameObject ChuotThuong;
    public GameObject ChuotVang2;
    public GameObject chuotkc1;
    public GameObject chuotkc2;
    public GameObject chuotkc3;
    public GameObject vang3;
    public GameObject vang2;
    public GameObject vang1;
    public GameObject da3;
    public GameObject KC1;
    public GameObject KC2;
    public GameObject KC3;
    public GameObject TuiQua;

    UIManager ui;
    int totalScore;

    int level;
    // Start is called before the first frame update
    void Start()
    {
        level = SceneManager.GetActiveScene().buildIndex; ;

        ui = FindObjectOfType<UIManager>();
        totalScore = 0;
        CheckLevel();

    }

    // Update is called once per frame
    void Update()
    {
        checkResult();
    }

    void spawnMouse()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-12, 12), Random.Range(-4, 0));
        if (ChuotThuong)
        {
            Instantiate(ChuotThuong, spawnPosition, Quaternion.identity);
        }
    }
    void spawnMouseGold2()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-12, 12), Random.Range(-5, -3));
        if (ChuotVang2)
        {
            Instantiate(ChuotVang2, spawnPosition, Quaternion.identity);
        }
    }
    void spawnMousekc1()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-12, 12), Random.Range(-9, -5));
        if (chuotkc1)
        {
            Instantiate(chuotkc1, spawnPosition, Quaternion.identity);
        }
    }
    void spawnMousekc2()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-12, 12), Random.Range(-9, -5));
        if (chuotkc2)
        {
            Instantiate(chuotkc2, spawnPosition, Quaternion.identity);
        }
    }
    void spawnMousekc3()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-12, 12), Random.Range(-9, -7));
        if (chuotkc3)
        {
            Instantiate(chuotkc3, spawnPosition, Quaternion.identity);
        }
    }
    void spawnGold3()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-12, 12), Random.Range(-9, -3));
        if (vang3)
        {
            Instantiate(vang3, spawnPosition, Quaternion.identity);
        }
    }

    void spawnGold2()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-12, 12), Random.Range(-5, -3));
        if (vang2)
        {
            Instantiate(vang2, spawnPosition, Quaternion.identity);
        }
    }
    void spawnGold1()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-12, 12), Random.Range(-4, 0));
        if (vang1)
        {
            Instantiate(vang1, spawnPosition, Quaternion.identity);
        }
    }

    void spawnDa3()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-12, 12), Random.Range(-4, 0));
        if (da3)
        {
            Instantiate(da3, spawnPosition, Quaternion.identity);
        }
    }
    void spawnKC1()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-12, 12), Random.Range(-9, -5));
        if (KC1)
        {
            Instantiate(KC1, spawnPosition, Quaternion.identity);
        }
    }

    void spawnKC2()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-12, 12), Random.Range(-9, -5));
        if (KC2)
        {
            Instantiate(KC2, spawnPosition, Quaternion.identity);
        }
    }

    void spawnKC3()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-12, -8), Random.Range(-9, -7));
        if (KC3)
        {
            Instantiate(KC3, spawnPosition, Quaternion.identity);
        }
    }
    void spawnTuiQua()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-12, 12), Random.Range(-9, -2));
        if (TuiQua)
        {
            Instantiate(TuiQua, spawnPosition, Quaternion.identity);
        }
    }

    void CheckLevel()
    {
        if (level == 1)
        {
            spawnGold1();
            spawnGold1();
            spawnGold1();
            spawnGold1();
            spawnGold1();
            spawnGold1();
            spawnGold1();
            spawnGold1();
            spawnGold1();
            spawnGold2();
            spawnGold2();
            spawnGold2();
            spawnGold2();
            spawnDa3();
            spawnDa3();
            spawnDa3();
        }
        else if (level == 2)
        {
            spawnGold1();
            spawnGold1();
            spawnGold1();
            spawnGold1();
            spawnGold1();
            spawnGold1();
            spawnGold1();
            spawnGold2();
            spawnGold2();
            spawnGold2();
            spawnGold2();
            spawnGold3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
        }
        else if (level == 3)
        {
            spawnGold1();
            spawnGold1();
            spawnGold1();
            spawnGold2();
            spawnGold2();
            spawnGold2();
            spawnGold2();
            spawnGold3();
            spawnGold3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnMouse();
            spawnMouse();
            spawnMouseGold2();
            spawnMouseGold2();
            spawnMouseGold2();
            spawnMouseGold2();
        }
        else if (level == 4)
        {
            spawnKC1();
            spawnGold1();
            spawnGold1();
            spawnGold2();
            spawnGold2();
            spawnGold2();
            spawnGold3();
            spawnGold3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnMouse();
            spawnMouseGold2();
            spawnMouseGold2();
            spawnTuiQua();
            spawnTuiQua();
        }
        else if (level == 5)
        {
            spawnKC1();
            spawnKC1();
            spawnGold1();
            spawnGold1();
            spawnGold2();
            spawnGold2();
            spawnGold2();
            spawnGold2();
            spawnGold3();
            spawnGold3();
            spawnGold3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnMouse();
            spawnMouseGold2();
            spawnMousekc1();
        }
        else if (level == 6)
        {
            spawnKC1();
            spawnKC2();
            spawnGold1();
            spawnGold1();
            spawnGold2();
            spawnGold2();
            spawnGold2();
            spawnGold2();
            spawnGold3();
            spawnGold3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnMouse();
            spawnMouseGold2();
            spawnMousekc1();
            spawnMousekc1();
        }
        else if (level == 7)
        {
            spawnKC1();
            spawnKC2();
            spawnKC2();
            spawnGold1();
            spawnGold1();
            spawnGold2(); 
            spawnGold2();
            spawnGold3();
            spawnGold3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnMouse();
            spawnMouseGold2();
            spawnMousekc1();
            spawnMousekc2();
            spawnMousekc1();
        }
        else if (level == 8)
        {
            spawnKC1();
            spawnKC2();
            spawnKC2();
            spawnKC3();
            spawnGold1();
            spawnGold2();
            spawnGold2();
            spawnGold2();
            spawnGold2();
            spawnGold2();
            spawnGold2();
            spawnGold2();
            spawnGold3();
            spawnGold3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnMouse();
            spawnMouseGold2();
            spawnTuiQua();
            spawnMousekc2();
            spawnMousekc2();
        }
        else if (level == 9)
        {
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnDa3();
            spawnGold3();
            spawnMouse();
            spawnMouse();
            spawnMousekc1();
            spawnMousekc2();
            spawnMousekc2();
            spawnKC3();
            spawnTuiQua();
        }
        else if (level == 10)
        {
            spawnKC3();
            spawnMousekc3();
            spawnMousekc3();
            spawnMousekc3();
        }
    }

    public void IncrementScore(int score)
    {
        AudioManager.instance.PlaySound(AudioManager.instance.congtien, 1f);
        totalScore = totalScore + score;
        ui.setScoreText(totalScore + "$");
        ui.Congdiem("+" + score + "$");
    }

    void checkResult()
    {
        if (ui.setTimeOver())
        {
            ui.setTimeOver();
        }
        else if (level == 1)
        {
            if(totalScore >= 542)
            {
                ui.ShowGameVictoryPanel(true);
            }
            else
            {
                ui.ShowGameOverPanel(true);
            }
        }
        else if (level == 2)
        {
            if (totalScore >= 1091)
            {
                ui.ShowGameVictoryPanel(true);
            }
            else
            {
                ui.ShowGameOverPanel(true);
            }
        }
        else if (level == 3)
        {
            if (totalScore >= 1286)
            {
                ui.ShowGameVictoryPanel(true);
            }
            else
            {
                ui.ShowGameOverPanel(true);
            }
        }
        else if (level == 4)
        {
            if (totalScore >= 1862)
            {
                ui.ShowGameVictoryPanel(true);
            }
            else
            {
                ui.ShowGameOverPanel(true);
            }
        }
        else if (level == 5)
        {
            if (totalScore >= 2023)
            {
                ui.ShowGameVictoryPanel(true);
            }
            else
            {
                ui.ShowGameOverPanel(true);
            }
        }
        else if (level == 6)
        {
            if (totalScore >= 2351)
            {
                ui.ShowGameVictoryPanel(true);
            }
            else
            {
                ui.ShowGameOverPanel(true);
            }
        }
        else if (level == 7)
        {
            if (totalScore >= 2776)
            {
                ui.ShowGameVictoryPanel(true);
            }
            else
            {
                ui.ShowGameOverPanel(true);
            }
        }
        else if (level == 8)
        {
            if (totalScore >= 3513)
            {
                ui.ShowGameVictoryPanel(true);
            }
            else
            {
                ui.ShowGameOverPanel(true);
            }
        }
        else if (level == 9)
        {
            if (totalScore >= 4062)
            {
                ui.ShowGameVictoryPanel(true);
            }
            else
            {
                ui.ShowGameOverPanel(true);
            }
        }
        else if (level == 10)
        {
            if (totalScore >= 6033)
            {
                ui.ShowGameVictoryPanel(true);
            }
            else
            {
                ui.ShowGameOverPanel(true);
            }
        }
    }
    public void Replay()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        //Debug.Log(currentScene);
        SceneManager.LoadScene(currentScene);
    }

    public void NextLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        //Debug.Log(currentScene);
        SceneManager.LoadScene(currentScene+1);
    }
    public void QuitGame()
    {
        SceneManager.LoadScene(11);
    }
    public void Reload()
    {
        //string currentScene = SceneManager.GetActiveScene().name;
        //Debug.Log(currentScene);
        SceneManager.LoadScene(0);
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public  void ResumeGame()
    {
        Time.timeScale = 1;
    }

}
