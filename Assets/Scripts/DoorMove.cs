using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour
{
    public bool isSolved;
    public float open;
    public Vector3 rotation;
    public string type;
    public Vector3 startPos;
    public float size;
    public Quaternion startRot;
    // Start is called before the first frame update
    void Start()
    {
        isSolved = false;
        open = 0;
        startPos = transform.position;
        startRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(isSolved == true)
        {
            rotation = gameObject.transform.rotation.eulerAngles;
            if(open < 8)
            {
                open += 0.025f;
                if(type == "x")
                {
                    gameObject.transform.position = new Vector3(open + startPos.x,gameObject.transform.position.y,gameObject.transform.position.z);
                    rotation.z += size;
                }
                if(type == "y")
                {
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,open + startPos.z);
                    rotation.z += size;
                }
                gameObject.transform.rotation = Quaternion.Euler(rotation);
            }
        }
        if(isSolved == false)
        {
            open = 0;
            gameObject.transform.position = startPos;
            gameObject.transform.rotation = startRot;
        }
    }
}