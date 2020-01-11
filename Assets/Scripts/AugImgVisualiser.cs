using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;


public class AugImgVisualiser : MonoBehaviour
{
     public AugmentedImage ImageToBeVisualised;
    public GameObject Center;

    // Update is called once per frame
    void Update()
    {
        if (ImageToBeVisualised == null || ImageToBeVisualised.TrackingState != TrackingState.Tracking)
        {
            Center.SetActive(false);
            return;
        }
        var centerText = Center.transform.GetChild(0).gameObject;
        centerText.GetComponent<TMPro.TextMeshPro>().text = "Sanned & Identified";
    }
}
