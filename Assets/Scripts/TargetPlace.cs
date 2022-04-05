using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlace : MonoBehaviour
{
    public GraphParticles grapher;
    public Vector3 grapherPos;
    public Vector3 pos; 
    public ParticleSystem targetParticles;
    public string grapherName;
    // Start is called before the first frame update
    void Start()
    {
        grapher = GameObject.Find(grapherName).GetComponent<GraphParticles>();
        grapherPos = GameObject.Find(grapherName).transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        pos.x = grapher.targetPos.x + grapherPos.x;
        pos.y = grapher.targetPos.y + grapherPos.y;
        pos.z = grapherPos.z;
        transform.position = pos;
    }
}
