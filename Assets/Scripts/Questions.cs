using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questions : MonoBehaviour
{
    public int roomNum = 0;
    public bool roomChange;
    public int chooseGraph;
    public Text txt;
    public GraphParticles grapher;
    public DoorMove doorMove;
    // Start is called before the first frame update
    void Start()
    {
        grapher = GameObject.Find("Grapher").GetComponent<GraphParticles>();
        doorMove = GameObject.Find("Door").GetComponent<DoorMove>();
        txt.text = "Create a graph which intersects the point (5, 5)";
    }

    // Update is called once per frame
    void Update()
    {
        if (roomChange)
        {
            roomNum++;
            roomChange = false;
            doorMove.isSolved = false;
            int xVal = Random.Range(1, 10);
            int yVal = Random.Range(1, 10);
            chooseGraph = Random.Range(1,5);
            if(chooseGraph == 1)
            {
                grapher.graphType = "SlopeIntercept";
            }
            if(chooseGraph == 2)
            {
                grapher.graphType = "ParabolaFunction";
            }
            if(chooseGraph == 3)
            {
                grapher.graphType = "SineFunction";
            }
            if(chooseGraph == 4)
            {
                grapher.graphType = "CosineFunction";
            }
            txt.text = "Create a graph which intersects the point (" + xVal + ", " + yVal + ")";
            grapher.targetPos.x = xVal;
            grapher.targetPos.y = yVal;
        }
    }
}
