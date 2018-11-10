using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changetext : MonoBehaviour {


    public Text mytext = '#strainthewall'
	// Use this for initialization
	void Start () {
		mytext.text = '#buildtheramen'
	}
	
	// Update is called once per frame
	void Update () {
        CharacterController controller = GetComponent<CharacterController>();
        OVRInput.Update(); // Call before checking the input
        if (OVRInput.Get(OVRInput.Button.One))
        {
            mytext.text = 'tims a bitch'
        }
    }
}
