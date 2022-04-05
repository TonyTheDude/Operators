using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EventTriggerMyUIButton : EventTrigger
{

    public Button button;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnPointerEnter(PointerEventData data)
    {
        //Debug.Log("OnPointerEnter called.");
    }

    public override void OnPointerClick(PointerEventData data)
    {
        //Debug.Log("OnPointerClick called.");
        gameObject.SendMessage("changeGameScene");
    }

    public override void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("OnPointerEnter called.");
    }
}
