using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufoRotate : MonoBehaviour{

    public GameObject playerObj;
    PlayerController playerController;
    public int rotationSpeed = 80;

    float forwardTilt = 0f;
    float sideTilt = 0f;
    // bool goUp = true;
    // public float currentWobble = 1.1f;
    // public float minWobble = -1f;
    // public float maxWobble = 1f;
    // public float wobbleSpeed = 5f;

    void Start(){
        playerController = playerObj.GetComponent<PlayerController>();
    }
   
    void Update(){

        // if(currentWobble > maxWobble && goUp){ goUp = false;} 
        // else if(currentWobble < minWobble&& !goUp) {goUp = true;}
        // if(goUp){ currentWobble += 0.01f;}
        // else{currentWobble -= 0.01f;}

        forwardTilt = playerController.forwardTilt;
        sideTilt = playerController.sideTilt;

        transform.Rotate(0f, rotationSpeed*Time.deltaTime, 0f);
        
    }
}
