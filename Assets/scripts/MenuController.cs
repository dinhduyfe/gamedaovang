using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.PlaySound(AudioManager.instance.nhacnen, 0.3f,true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void MenuLevel()
    {
        //string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(11);
    }

    public void Play()
    {
        //string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(1);
    }
    public void PlayLevel1()
    {
        //string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(1);
    }
    public void PlayLevel2()
    {
        //string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(2);
    }
    public void PlayLevel3()
    {
        //string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(3);
    }
    public void PlayLevel4()
    {
        //string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(4);
    }
    public void PlayLevel5()
    {
        //string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(5);
    }
    public void PlayLevel6()
    {
        //string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(6);
    }
    public void PlayLevel7()
    {
        //string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(7);
    }
    public void PlayLevel8()
    {
        //string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(8);
    }
    public void PlayLevel9()
    {
        //string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(9);
    }
    public void PlayLevel10()
    {
        //string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(10);
    }

    public void BackToHome()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
    }
}
