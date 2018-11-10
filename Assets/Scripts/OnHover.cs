

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class OnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {

    private Image image;

    void Start()
    {
        image = GetComponent<Image> ();
    }


    public void OnPointerEnter(PointerEventData eventData) 
    {
        OnHoverEnter ();
    }

    public void OnPointerExit(PointerEventData eventData) 
    {
        OnHoverExit ();
    }

    public void OnPointerClick(PointerEventData eventData) 
    {
        OnClick ();
    }

    void OnHoverEnter() 
    {
        image.color = Color.gray;
    }

    void OnHoverExit()
    {
        image.color = Color.white;
    }

    void OnClick()
    {
        image.color = Color.blue;
    }

}
 