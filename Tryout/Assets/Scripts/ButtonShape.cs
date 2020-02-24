using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class ButtonShape : MonoBehaviour
{
    public float AlphaThreshold = 0.1f;

    void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = AlphaThreshold;
    }
}
