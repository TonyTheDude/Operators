using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIScript : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject menuPanel;
    void Start()
    {
        menuPanel = transform.GetChild(0).gameObject;
        menuPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
