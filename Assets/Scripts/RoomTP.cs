using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTP : MonoBehaviour
{

    public GameObject player;
    public Questions questions;
    // Start is called before the first frame update
    void Start()
    {
        questions = gameObject.GetComponent<Questions>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("yolo " + collision.gameObject);
        if (collision.gameObject == player)
        {
            player.transform.position = new Vector3(player.transform.position.x, 1.5f, player.transform.position.z-40);
            player.transform.rotation = (player.transform.rotation);
            questions.roomChange = true;
            //Debug.Log(player.transform);
        }
    }
}
