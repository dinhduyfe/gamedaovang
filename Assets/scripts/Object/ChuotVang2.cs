using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuotVang2 : MonoBehaviour
{
    Animator animator;
    float time_xDir;
    float moveSpeed = 3;
    int xDir = -1;

    bool change = false;
    float time_change = 1f;
    bool bikeo = false;

    public GameObject luoicau;
    Gamecontroller gc;

    // Start is called before the first frame update
    void Start()
    {
        gc = FindObjectOfType<Gamecontroller>();
        luoicau = GameObject.Find("luoiCau");
        animator = GetComponent<Animator>();
        time_xDir = 1;
    }

    // Update is called once per frame
    void Update()
    {

        setMoveChuot();
        checkBiKeo();
    }

    public void setMoveChuot()
    {

        time_xDir = time_xDir - Time.deltaTime;
        if (time_xDir <= 0)
        {
            time_xDir = 2;
            if (transform.position.x <= Random.Range(-7, 0))
            {
                xDir = 1;
                AnimationChuot(xDir);
                change = true;
            }
            if (transform.position.x >= Random.Range(0, 7))
            {
                xDir = -1;
                AnimationChuot(xDir);
                change = true;
            }
        }
        if (change)
        {
            time_change = time_change - Time.deltaTime;
            if (time_change <= 0)
            {
                time_change = 1f;
                change = false;
                transform.position = transform.position + Vector3.right * xDir * moveSpeed * Time.deltaTime;
            }
        }
        else
        {
            transform.position = transform.position + Vector3.right * xDir * moveSpeed * Time.deltaTime;
        }
    }

    public void AnimationChuot(int status)
    {
        if (status == -1)
        {
            animator.SetInteger("ChuotVang2", 0);
        }
        else if (status == 1)
        {
            animator.SetInteger("ChuotVang2", 1);
        }
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
            gc.IncrementScore(219);
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
