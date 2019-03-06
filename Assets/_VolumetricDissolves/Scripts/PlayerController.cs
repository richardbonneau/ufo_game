using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    public CharacterController characterController;
    public GameObject model;
    public GameObject spotlight;
    public int movementSpeed = 1;
    public int rotationSpeed = 50;
    public float forwardTilt = 0f;
    public float sideTilt = 0f;
    // Start is called before the first frame update
    void Start(){
        characterController = GetComponent<CharacterController>();

    }
 
    // Update is called once per frame
    void Update(){
        //WASD
        if(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
            forwardTilt = 15f;
        } else if(Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
            forwardTilt = -15f;
        }
        
        transform.Rotate(0, Input.GetAxis("Horizontal")*Time.deltaTime * rotationSpeed, 0);

        //Mouse
        if(Input.GetMouseButton(0)){
            spotlight.SetActive(true);
        } else {
            spotlight.SetActive(false);
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray)){
            spotlight.transform.LookAt(ray.GetPoint(10));
        }
    }

}
