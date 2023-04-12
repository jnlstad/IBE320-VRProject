using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyHoleDoorTrigger : MonoBehaviour
{
    [SerializeField] private Animator doorLeft = null;
    [SerializeField] private Animator doorRight = null;
    [SerializeField] private GameObject key = null;

    [SerializeField] private bool openTrigger = false;
    
    [SerializeField] private string DoorOpenRight = "DoorOpenRight";
    [SerializeField] private string DoorOpenLeft = "DoorOpenLeft";

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("doorKey"))
        {
            if (openTrigger)
            {
                doorLeft.Play(DoorOpenLeft, 0, 0.0f);
                doorRight.Play(DoorOpenRight, 0, 0.0f);
                gameObject.SetActive(false);
                key.SetActive(false);
            }
        }
    }
}
