using UnityEngine;
using System.Collections;

public class DayCauController : MonoBehaviour
{
    public Transform luoicauTransform;

    int rotatexDir = 1;
    float rotateSpeed = 1.8f;
    //bool is_input ;
    float Length;

    private void Awake()
    {
        
    }

    private void Start()
    {
        luoicauTransform = GameObject.Find("luoiCau").transform;
        //initAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
    }

    private void Update()
    {
        gameObject.GetComponent<LineRenderer>().SetPosition(0, transform.position);
        gameObject.GetComponent<LineRenderer>().SetPosition(1, luoicauTransform.position);

       /* checkPosition();
        checkInput();*/
    }

    public void rotate(bool is_input)
    {
        if (transform.localRotation.z >= 0.6)
        {
            rotatexDir = -1;
        }
        if (transform.localRotation.z <= -0.6)
        {
            rotatexDir = 1;
        }
        if (is_input == false)
            transform.Rotate(0f, 0.0f, 1.0f * rotatexDir * rotateSpeed);
    }

    /*void checkPosition(bool is_input)
    {
        Vector3 position1 = gameObject.GetComponent<LineRenderer>().GetPosition(1);
        Vector3 position0 = gameObject.GetComponent<LineRenderer>().GetPosition(0);
        Length = Mathf.Sqrt(Mathf.Pow(position1.x - position0.x, 2) + Mathf.Pow(position1.y - position0.y, 2));
        if (Length <= 0.6685f) is_input = false;
    }

    void checkInput(bool is_input)
    {
        if (Input.GetKeyDown("space")  || (Input.GetMouseButtonDown(0)))
        {
            is_input = true;
        }
    }*/

    


}
