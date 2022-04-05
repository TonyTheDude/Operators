using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TabletInput : MonoBehaviour
{
    public TabletControl tablet;
    public float maxInputField;
    public float inputField;
    public TextMeshPro input;
    public float pendingInput;
    public float input1;
    public float input2;
    public float input3;
    public GraphParticles grapher;
    // Start is called before the first frame update
    void Start()
    {
        grapher = GameObject.Find("Grapher").GetComponent<GraphParticles>();
        input = gameObject.GetComponent<TextMeshPro>();
        tablet = GameObject.Find("Tablet").GetComponent<TabletControl>();
        pendingInput = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(tablet.drawn == true)
        {
            if(grapher.graphType == "SlopeIntercept")
            {
                maxInputField = 2;
                if(inputField == 1)
                {
                    input.text = "Equation:\ny = mx + b\nvalues:\nm = <color=red>" + input1 + "<color=black> b = " + input2;
                }
                else
                {
                    if(inputField == 2)
                    {
                        input.text = "Equation:\ny = mx + b\nvalues:\nm = " + input1 + " b = <color=red>" + input2;
                    }
                }
                if(Input.GetKeyDown(KeyCode.Return))
                {
                    grapher.m = input1;
                    grapher.b = input2;
                    grapher.isGraph = true;
                }
                
            }
            if(grapher.graphType == "ParabolaFunction")
            {
                maxInputField = 3;
                if(inputField == 1)
                {
                    input.text = "Equation:\ny = m(x - d)<sup>2</sup> + b\nvalues:\nm = <color=red>" + input1 + "<color=black> d = " + input2 + " \nb = " + input3;
                }
                else
                {
                    if(inputField == 2)
                    {
                        input.text = "Equation:\ny = m(x - d)<sup>2</sup> + b\nvalues:\nm = " + input1 + " d = <color=red>" + input2 + "<color=black> \nb = " + input3;
                    } 
                    else
                    {
                        if(inputField == 3)
                        {
                            input.text = "Equation:\ny = m(x - d)<sup>2</sup> + b\nvalues:\nm = " + input1 + " d = " + input2 + " \nb = <color=red>" + input3;
                        }
                    }
                }
                if(Input.GetKeyDown(KeyCode.Return))
                {
                    grapher.m = input1;
                    grapher.d = input2;
                    grapher.b = input3;
                    grapher.isGraph = true;
                }
                
            }
            if(grapher.graphType == "SineFunction")
            {
                maxInputField = 3;
                if(inputField == 1)
                {
                    input.text = "Equation:\ny = m * sin(x - d) + b\nvalues:\nm = <color=red>" + input1 + "<color=black> d = " + input2 + " \nb = " + input3;
                }
                else
                {
                    if(inputField == 2)
                    {
                        input.text = "Equation:\ny = m * sin(x - d) + b\nvalues:\nm = " + input1 + " d = <color=red>" + input2 + "<color=black> \nb = " + input3;
                    } 
                    else
                    {
                        if(inputField == 3)
                        {
                            input.text = "Equation:\ny = m * sin(x - d) + b\nvalues:\nm = " + input1 + " d = " + input2 + " \nb = <color=red>" + input3;
                        }
                    }
                }
                if(Input.GetKeyDown(KeyCode.Return))
                {
                    grapher.m = input1;
                    grapher.d = input2;
                    grapher.b = input3;
                    grapher.isGraph = true;
                }
                
            }
            if(grapher.graphType == "CosineFunction")
            {
                maxInputField = 3;
                if(inputField == 1)
                {
                    input.text = "Equation:\ny = m * cos(x + d) - b\nvalues:\nm = <color=red>" + input1 + "<color=black> d = " + input2 + " \nb = " + input3;
                }
                else
                {
                    if(inputField == 2)
                    {
                        input.text = "Equation:\ny = m * cos(x + d) - b\nvalues:\nm = " + input1 + " d = <color=red>" + input2 + "<color=black> \nb = " + input3;
                    } 
                    else
                    {
                        if(inputField == 3)
                        {
                            input.text = "Equation:\ny = m * cos(x + d) - b\nvalues:\nm = " + input1 + " d = " + input2 + " \nb = <color=red>" + input3;
                        }
                    }
                }
                if(Input.GetKeyDown(KeyCode.Return))
                {
                    grapher.m = input1;
                    grapher.d = input2;
                    grapher.b = input3;
                    grapher.isGraph = true;
                }
                
            }
            if(Input.GetKeyDown(KeyCode.Tab) && inputField < maxInputField)
            {
                inputField += 1;
            }
            else
            {
                if(Input.GetKeyDown(KeyCode.Tab) && inputField == maxInputField)
                {
                    inputField = 1;
                }
            }
            if(Input.GetKeyDown(KeyCode.Alpha0))
            {
                pendingInput = 0;
            }
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                pendingInput = 1;
            }
            if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                pendingInput = 2;
            }
            if(Input.GetKeyDown(KeyCode.Alpha3))
            {
                pendingInput = 3;
            }
            if(Input.GetKeyDown(KeyCode.Alpha4))
            {
                pendingInput = 4;
            }
            if(Input.GetKeyDown(KeyCode.Alpha5))
            {
                pendingInput = 5;
            }
            if(Input.GetKeyDown(KeyCode.Alpha6))
            {
                pendingInput = 6;
            }
            if(Input.GetKeyDown(KeyCode.Alpha7))
            {
                pendingInput = 7;
            }
            if(Input.GetKeyDown(KeyCode.Alpha8))
            {
                pendingInput = 8;
            }
            if(Input.GetKeyDown(KeyCode.Alpha9))
            {
                pendingInput = 9;
            }
            if(pendingInput != 10)
            {
                if(inputField == 1)
                {
                    input1 = pendingInput;
                }
                if(inputField == 2)
                {
                    input2 = pendingInput;
                }
                if(inputField == 3)
                {
                    input3 = pendingInput;
                }
                pendingInput = 10;
            }
        }
    }
}
