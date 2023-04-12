using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batteryFlashlightTrigger : MonoBehaviour
{
    [SerializeField] private GameObject hintTrigger = null;
    [SerializeField] private GameObject exitBlocker = null;
    [SerializeField] private GameObject battery = null;
    [SerializeField] private GameObject flashlight = null;
    [SerializeField] private GameObject handFlashLight = null;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("doorKey"))
        {
            hintTrigger.SetActive(false);
            exitBlocker.SetActive(false);
            battery.SetActive(false);
            flashlight.SetActive(false); // The Flashlight
            handFlashLight.SetActive(true);
        }
    }
}
