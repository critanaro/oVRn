
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]

public class activescrpt : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    private Image image;
    public dial2_controller dial;

    void Start()
    {
        image = GetComponent<Image>();
        dial.GetComponent<dial2_controller>().setHovered(false);
    }


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
        print("hovered");
        dial.GetComponent<dial2_controller>().setHovered(true);
       // image.color = Color.gray;
    }

    void OnHoverExit()
    {
        print("unhovered");
        dial.GetComponent<dial2_controller>().setHovered(false);
        //image.color = Color.blue;
    }

    void OnClick()
    {
        print("Clicked");
    }

}
