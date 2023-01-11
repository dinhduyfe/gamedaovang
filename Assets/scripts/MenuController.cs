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
    public void Play()
    {
        //string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(1);
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
