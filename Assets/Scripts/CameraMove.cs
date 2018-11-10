using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    GameObject playerObj;
	// Use this for initialization
	void Start () {
        playerObj = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void LateUpdate () {
        print("B: " + transform.position);
        transform.position = playerObj.transform.position;
	}
}
