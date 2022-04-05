using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphParticles : MonoBehaviour
{
    public ParticleSystem graphpart;
    public TargetPlace target;
    public bool isGraph;
    public string graphType;
    public float m;
    public float b;
    public float d;
    public float y;
    public float x;
    public Vector3 startPos;
    public Vector3 targetPos;
    public ParticleSystem targetParticles;
    public DoorMove doorMove;
    public string doorName;
    public string targetName;
    // Start is called before the first frame update
    void Start()
    {
        doorMove = GameObject.Find(doorName).GetComponent<DoorMove>();
        targetParticles = GameObject.Find(targetName).GetComponent<ParticleSystem>();
        startPos = transform.position;
        graphpart = gameObject.GetComponent<ParticleSystem>();
        target = GameObject.Find(targetName).GetComponent<TargetPlace>();
        graphpart.Stop();
        x = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGraph == true)
        {
            graphpart.Play();
            isGraph = false;    
            x = 0;
            if(targetPos.y == m* targetPos.x + b && graphType == "SlopeIntercept")
            {
                doorMove.isSolved = true;
                targetParticles.Play();
            }
            if(targetPos.y == m * ((targetPos.x - d) * (targetPos.x - d)) + b && graphType == "ParabolaFunction")
            {
                doorMove.isSolved = true;
                targetParticles.Play();
            }
            if(targetPos.y == m * Mathf.Sin(targetPos.x - d) + b && graphType == "SineFunction")
            {
                doorMove.isSolved = true;
                targetParticles.Play();
            }
            if(targetPos.y == m * Mathf.Cos(targetPos.x - d) + b && graphType == "CosineFunction")
            {
                doorMove.isSolved = true;
                targetParticles.Play();
            }
        }
        if(x < 10)
        {
            if(graphType == "SlopeIntercept")
            {
                gameObject.transform.position = new Vector3(startPos.x + x,startPos.y + m * x + b,startPos.z);
                
            }

            if (graphType == "ParabolaFunction")
            {
                gameObject.transform.position = new Vector3(startPos.x + x, startPos.y + m * ((x - d) * (x - d)) + b, startPos.z);

            }

            if (graphType == "SineFunction")
            {
                gameObject.transform.position = new Vector3(startPos.x + x, startPos.y + m * Mathf.Sin(x - d) + b, startPos.z);

            }
            if (graphType == "CosineFunction")
            {
                gameObject.transform.position = new Vector3(startPos.x + x, startPos.y + m * Mathf.Cos(x - d) + b, startPos.z);

            }
            if (graphType == "InvSineFunction")
            {
                gameObject.transform.position = new Vector3(startPos.x + x, startPos.y + m * Mathf.Asin(x - d) + b, startPos.z);

            }
            if (graphType == "InvCosineFunction")
            {
                gameObject.transform.position = new Vector3(startPos.x + x, startPos.y + m * Mathf.Acos(x - d) + b, startPos.z);

            }
            if (graphType == "TangentFunction")
            {
                gameObject.transform.position = new Vector3(startPos.x + x, startPos.y + m * Mathf.Tan(x - d) + b, startPos.z);

            }
            if (graphType == "InvTangentFunction")
            {
                gameObject.transform.position = new Vector3(startPos.x + x, startPos.y + m * Mathf.Atan(x + d) + b, startPos.z);

            }
            x += 0.1f;
        }
        if(x >= 10)
        {
            graphpart.Stop();
            transform.position = startPos;
        }
        
    }
}
