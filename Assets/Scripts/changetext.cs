using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class changetext : MonoBehaviour {
    // Use this for initialization
    public Text mytext;
    void Start () {
        mytext = FindObjectOfType<Text>();
        state_off();
	}
	
	// Update is called once per frame
	void Update () {
        /*CharacterController controller = GetComponent<CharacterController>();
        OVRInput.Update(); // Call before checking the input
        if (OVRInput.Get(OVRInput.Button.One))
        {
            mytext.text = "tims a bitch";
        }*/
    }

    public void state_3()
    {
        mytext.text = "This fire is too small...";
        Debug.Log("state 3 has been called");
    }
    public void state_6()
    {
        mytext.text = "This fire is just right!";
    }
    public void state_9()
    {
        mytext.text = "This fire is too big!!!";
    }
    public void state_off()
    {
        mytext.text = "There is no fire...";
    }
}
