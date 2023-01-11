using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuoiCauController : MonoBehaviour
{
    Animator animator;
    Transform daycauTransform;
    //public Transform LuoiCau;
    bool ckeckInput = false;
    bool Outside = false;
    bool keoTrung = false;

    float moveSpeed = 5;
    float x_moc;
    float delay = 0;


    DayCauController dc;
    void Start()
    {
        animator = GetComponent<Animator>(); 
        daycauTransform = GameObject.Find("dayCau").transform;
        dc = FindObjectOfType<DayCauController>();
        
    }
    void Update()
    {
        CheckKeo();
    }

    public void CheckKeo()
    {
        delay = delay - Time.deltaTime;
        if (((Input.GetKeyDown("space") || (Input.GetKey(KeyCode.DownArrow))) && (delay<0)))
        {
            ckeckInput = true;
        }
        dc.rotate(ckeckInput);
        if (ckeckInput == true && Outside == false && keoTrung == false)
        {
            AudioManager.instance.PlaySound(AudioManager.instance.thaday, 1f);
            
            if (transform.eulerAngles.z <= 90)
            {
                x_moc = 1 * Mathf.Tan((float)transform.eulerAngles.z / 180 * Mathf.PI);
            }
            else
            {
                x_moc = -1 * Mathf.Tan((float)(360 - transform.eulerAngles.z) / 180 * Mathf.PI);
            }
            if (x_moc < 1.5) moveSpeed = 5f;
            if (x_moc >=1.5) moveSpeed = 4f;
            if (x_moc >=3) moveSpeed = 3f;
            if (x_moc >= 5) moveSpeed = 1.5f;
            transform.position = transform.position + new Vector3(x_moc,-1,0) * (moveSpeed) * Time.deltaTime;
            checkOutside();
        }
        else if(Outside == true || keoTrung == true)
        {
            AudioManager.instance.StopSound(AudioManager.instance.thaday);
            AudioManager.instance.PlaySound(AudioManager.instance.keoday, 1f);
            transform.position = transform.position + new Vector3(-x_moc, 1, 0) * (moveSpeed) * Time.deltaTime;
            checkLength();
        }
    }

    void checkOutside()
    {
        if (transform.position.x <= -13 || transform.position.y <= -9 || transform.position.x >= 13)
        {
            Outside = true;
        }    
    }

    void checkLength()
    {
        float Length = Mathf.Sqrt(Mathf.Pow(daycauTransform.position.x - transform.position.x, 2) + Mathf.Pow(daycauTransform.position.y - transform.position.y, 2));
        if (Length <= 0.6685f)
        {
            keoTrung = false;
            ckeckInput = false;
            Outside = false;
            delay = 0.5f;
            animator.SetInteger("statusLuoicau", 0);
            //AudioManager.instance.StopSound(AudioManager.instance.keoday);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (keoTrung == true) return;
        if (collision.gameObject.CompareTag("vang3"))
        {
            keoTrung = true;
            moveSpeed = moveSpeed / 5;
            animator.SetInteger("statusLuoicau", 1);
        }
        if (collision.gameObject.CompareTag("vang2"))
        {
            keoTrung = true;
            moveSpeed = moveSpeed / 3;
            animator.SetInteger("statusLuoicau", 1);
        }
        if (collision.gameObject.CompareTag("da3"))
        {
            keoTrung = true;
            moveSpeed = moveSpeed / 5;
            animator.SetInteger("statusLuoicau", 1);
        }
        if (collision.gameObject.CompareTag("chuotvang2"))
        {
            keoTrung = true;
            moveSpeed = moveSpeed / 3;
            animator.SetInteger("statusLuoicau", 1);
        }
        if (collision.gameObject.CompareTag("chuotkc1") || collision.gameObject.CompareTag("chuotkc2") 
            || collision.gameObject.CompareTag("chuotkc3") || collision.gameObject.CompareTag("chuotthuong")
            || collision.gameObject.CompareTag("vang1") || collision.gameObject.CompareTag("kc1") 
            || collision.gameObject.CompareTag("kc2") || collision.gameObject.CompareTag("kc3")
            || collision.gameObject.CompareTag("kc2") || collision.gameObject.CompareTag("qua"))
        {
            keoTrung = true;
            moveSpeed = moveSpeed / 1;
            animator.SetInteger("statusLuoicau", 1);
        }
    }
}
