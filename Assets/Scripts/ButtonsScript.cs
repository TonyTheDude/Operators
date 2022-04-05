using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public GameObject playButton;
    private bool isMouseOver;
    public int nextScreen;

    // Start is called before the first frame update
    void Start()
    {
        /* DO NOT UNCOMMENT, WILL BREAK!
        EventTrigger trigger = GetComponent<EventTrigger>();
        EventTrigger.Entry mouseOverUI = new EventTrigger.Entry();
        mouseOverUI.eventID = EventTriggerType.PointerEnter;
        mouseOverUI.callback.AddListener((data) => { OnPointerEnterFunct((PointerEventData)data); });
        */
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        //SceneManager.LoadSceneAsync(1);
        //SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(0));
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void changeGameScene()
    {
        Debug.Log("Game Scene Changed");
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneToUse));
        //SceneManager.LoadSceneAsync(nextScreen);
        gameObject.transform.parent.gameObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
