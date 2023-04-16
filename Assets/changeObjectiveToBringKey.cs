using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeObjectiveToBringKey : MonoBehaviour
{
    [SerializeField] public GameObject getKeyObjective = null;
    [SerializeField] public GameObject bringKeyToDoorObjective = null;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("doorKey")){
            getKeyObjective.SetActive(false);
            bringKeyToDoorObjective.SetActive(true);
            gameObject.SetActive(false);   
        }
    }    
}
