using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableTest : MonoBehaviour
{
    // È£¹ö
    public void HoverEnter()
    {
        Debug.Log("HoverEnter");
    }

    public void HoverExit()
    {
        Debug.Log("HoverExit");
    }

    public void HoverFirstEnter()
    {
        Debug.Log("HoverFirstEnter");
    }

    public void HoverLastExit()
    {
        Debug.Log("HoverLastExit");
    }


    public void SelectEnter()
    {
        Debug.Log("SelectEnter");
    }

    public void SelectExit()
    {
        Debug.Log("SelectExit");
    }

    public void Activated()
    {
        Debug.Log("Activated");
    }

    public void Deactivated()
    {
        Debug.Log("Deactivated");
    }
}
