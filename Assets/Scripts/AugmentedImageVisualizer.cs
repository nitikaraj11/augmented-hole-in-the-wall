
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using GoogleARCore;
    using GoogleARCoreInternal;
    using UnityEngine;

    /// <summary>
    /// Uses 4 frame corner objects to visualize an AugmentedImage.
    /// </summary>
    public class AugmentedImageVisualizer : MonoBehaviour
    {
        /// <summary>
        /// The AugmentedImage to visualize.
        /// </summary>
        public AugmentedImage Image;

        /// <summary>
        /// A model for the center of the frame to place when an image is detected.
        /// </summary>
        public GameObject Center;


        /// <summary>
        /// The Unity Update method.
        /// </summary>
        public void Update()
        {
            if (Image == null || Image.TrackingState != TrackingState.Tracking)
            {
                Center.SetActive(false);
                return;
            }

            var centerText = Center.transform.GetChild(0).gameObject;
            centerText.GetComponent<TMPro.TextMeshPro>().text = "Identified";

            Center.SetActive(true);
        }
    }

