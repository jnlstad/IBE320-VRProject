using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomDoorTrigger : MonoBehaviour
{
    [SerializeField] private Animator roomDoorOpen = null;

    [SerializeField] private string DoorOpenRight = "roomDoorOpen1";

    private void OnTriggerEnter(Collider other)
    {

        roomDoorOpen.Play(DoorOpenRight, 0, 0.0f);
        gameObject.SetActive(false);
        
    
    }    

}
