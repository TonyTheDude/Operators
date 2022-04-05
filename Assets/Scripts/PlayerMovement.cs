using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float xInput;
    float zInput;
    bool canJump;
    float jumpHeight = 8;
    float speed = 2;
    Rigidbody rb;
    Vector3 vec3 = new Vector3(0, 2.0f, 0);
    public GameObject cam;
    float sensitivity = 3;
    float hori;
    float vert;
    Vector3 cameraPos = new Vector3(0,1,0);
    float maxSpeed = 4;
    float airSpeed = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        RaycastHit hit;
        Ray dRay = new Ray(transform.position, -transform.up);
        if(Physics.Raycast(dRay, out hit, 1.05f, 1, QueryTriggerInteraction.Ignore))
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }

        //Player inputs
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        vert = Input.GetAxis("Mouse Y");
        hori = Input.GetAxis("Mouse X");
        if (canJump)
        {
            rb.AddForce(xInput * transform.right * speed, ForceMode.VelocityChange);
            rb.AddForce(zInput * transform.forward * speed, ForceMode.VelocityChange);
        }
        else
        {
            rb.AddForce((xInput * transform.right * speed)/airSpeed, ForceMode.VelocityChange);
            rb.AddForce((zInput * transform.forward * speed)/ airSpeed, ForceMode.VelocityChange);
        }

        rb.velocity = new Vector3(Mathf.Clamp(rb.velocity.x, -maxSpeed, maxSpeed), rb.velocity.y, Mathf.Clamp(rb.velocity.z, -maxSpeed, maxSpeed));
        //Checks if player is on the ground, and lets them jump if they are.
        if ((Input.GetKeyDown(KeyCode.Space) && canJump))
        {
            rb.AddForce(vec3 * jumpHeight, ForceMode.Impulse);
        }
        
        //camera stuff
        cam.transform.Rotate(Vector3.right, sensitivity * -vert);
        transform.RotateAround(transform.position, Vector3.up, sensitivity * hori);
        cam.transform.position = transform.position+cameraPos;
        cam.transform.rotation = Quaternion.Euler(cam.transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
    }
}
