using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractorTest : MonoBehaviour
{
    public void HoverEnter()
    {
        Debug.Log("HoverEnter");
    }

    public void HoverExited()
    {
        Debug.Log("HoverExited");
    }

    public void SelectEnter()
    {
        Debug.Log("SelectEnter");
    }

    public void SelectExited()
    {
        Debug.Log("SelectExited");
    }
}
