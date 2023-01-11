using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vang2 : MonoBehaviour
{

    bool bikeo = false;

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
        checkBiKeo();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("luoicau"))
        {
            transform.position = luoicau.transform.position;
            bikeo = true;
        }

        if (collision.gameObject.CompareTag("daycau"))
        {
            gc.IncrementScore(217);
            Destroy(gameObject);
        }
    }
    void checkBiKeo()
    {
        if (bikeo)
        {
            transform.position = luoicau.transform.position;
        }
    }
}
