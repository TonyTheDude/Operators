using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletControl : MonoBehaviour
{
    //public Vector3 mainCam;
    //public float vert;
    //public float mousePos;
    //public float tabletRot;
    public bool drawn;
    //public GameObject player;
    public Renderer visible;

    // Start is called before the first frame update
    void Start()
    {
        visible = gameObject.GetComponent<MeshRenderer>();
        //mainCam = transform.rotation.eulerAngles;
        //player = GameObject.Find("Player");
        visible.enabled = false;
        //visible.enabled = false;
        //GameObject.FindWithTag("MainCamera").
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && drawn == false)
        {
            drawn = true;
            visible.enabled = true;
        }
        else 
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) && drawn == true)
            {
                drawn = false;
                visible.enabled = false;
            }
        }
        //vert = Input.GetAxis("Mouse Y");
        
        //tabletRot = transform.rotation.eulerAngles.x;
        //tabletRot += vert;
        //tabletRot.x = tabletRot.x * -1;
        //tabletRot = Mathf.Clamp(tabletRot, -30, 30);
        
        //gameObject.transform.rotation = Quaternion.AngleAxis(tabletRot, Vector3.right);
        //gameObject.transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x, 0, 0);
    }
}
