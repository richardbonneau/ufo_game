using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour{
    // Renderer rend;
    public List<GameObject> pulledObjects = new List<GameObject>();
    GameObject pulledSingleObject;
    public float pullForce = 1f;
    public Vector3 forceDirection; 
    public GameObject pullPoint;

    void Start(){
         
    }

    void Update(){
        print("pulledSingleObject "+pulledSingleObject);

    }
    //**  Dissolves the cubes on contact
    // void OnTriggerEnter(Collider col){
    //     if(col.gameObject.CompareTag("Cube")){
    //         col.gameObject.GetComponent<Dissolve>().dissolveIt = true;
    //     }
    // }
    void FixedUpdate(){
        pulledSingleObject.GetComponent<Collider>().AddForce(forceDirection.normalized * pullForce * Time.fixedDeltaTime);
    }
       void OnTriggerEnter(Collider col){
         if(col.gameObject.CompareTag("Cube")){
            pulledSingleObject = col.gameObject;

        }
    }
}
