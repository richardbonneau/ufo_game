using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour{
    Renderer rend;
    public bool dissolveIt = false;
    float dissolveValue = 0f;
    float dissolveSpeed = 0.02f;
    // Start is called before the first frame update
    void Start(){
        rend = this.gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update(){
        if(dissolveIt){
            dissolveValue = dissolveValue + dissolveSpeed;
            rend.material.SetFloat("_DissolveCutoff", dissolveValue);
        }
    }
}
