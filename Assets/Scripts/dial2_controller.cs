using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using UnityEngine.EventSystems;

public class dial2_controller : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    Animator animator;
    int test = 0;
    public changetext text;
    public GameObject fireSmall;
    public GameObject firePerfect;
    public GameObject fireBad;
    public Boolean hovered;

    public void setHovered(Boolean buul)
    {
        hovered = buul;
    }
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.Play("dial2_p9");
        text.GetComponent<changetext>().state_off();
        fireSmall.SetActive(false);
        firePerfect.SetActive(false);
        fireBad.SetActive(false);
        hovered = false;
        //animator.SetBool("clicked", false);
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        OVRInput.Update(); // Call before checking the input
        int SLEEP_TIME = 200;
        if (hovered) { 
        if (OVRInput.Get(OVRInput.Button.One) && test == 0)
        {
            animator.Play("dial2_on");
            test = 1;
            Debug.Log(test + "dial 2 is now at 3");
            //animator.SetBool("clicked", true);
            Thread.Sleep(SLEEP_TIME);
            //animator.SetBool("clicked", false);
            text.state_3();
            fireSmall.SetActive(true);
            firePerfect.SetActive(false);
            fireBad.SetActive(false);
        }
        else if (OVRInput.Get(OVRInput.Button.One) && test == 1)
        {
            animator.Play("dial2_p3");
            test = 2;
            //test = 0;
            Debug.Log(test + "dial 2 is now at 6");
            //animator.SetBool("clicked", true);
            Thread.Sleep(SLEEP_TIME);
            //animator.SetBool("clicked", false);
            text.state_6();
            fireSmall.SetActive(false);
            firePerfect.SetActive(true);
            fireBad.SetActive(false);
        }
        else if (OVRInput.Get(OVRInput.Button.One) && test == 2)
        {
            animator.Play("dial2_p6");
            test = 3;
            Debug.Log(test + "dial 2 is now at 9");
            //animator.SetBool("clicked", true);
            Thread.Sleep(SLEEP_TIME);
            //animator.SetBool("clicked", false);
            text.state_9();
            fireSmall.SetActive(false);
            firePerfect.SetActive(false);
            fireBad.SetActive(true);
        }
        else if (OVRInput.Get(OVRInput.Button.One) && test == 3)
        {
            animator.Play("dial2_p9");
            test = 0;
            Debug.Log(test + "dial 2 is done yeet");
            //animator.SetBool("clicked", true);
            Thread.Sleep(SLEEP_TIME);
            //animator.SetBool("clicked", false);
            text.state_off();
            fireSmall.SetActive(false);
            firePerfect.SetActive(false);
            fireBad.SetActive(false);
        }
    }
    }

    //gaze-based activation stuff

    public void OnPointerEnter(PointerEventData eventData)
    {
        OnHoverEnter();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        OnHoverExit();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick();
    }

    void OnHoverEnter()
    {
        print("Hovered");
    }

    void OnHoverExit()
    {
        print("Unhovered");
    }

    void OnClick()
    {
        print("Clicked");
    }




}
