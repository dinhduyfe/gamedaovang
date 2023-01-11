using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuiQua : MonoBehaviour
{
    public GameObject luoicau;
    Gamecontroller gc;

    // Start is called before the first frame update
    void Start()
    {
        gc = FindObjectOfType<Gamecontroller>();
        luoicau = GameObject.Find("luoiCau");
    }

    // Update is called once per frame
    void Update()
    {

    }

    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("luoicau"))
        {
            gc.IncrementScore(Random.Range(100,1000));
            Destroy(gameObject);
        }
    }
}
