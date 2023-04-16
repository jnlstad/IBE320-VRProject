using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeObjectiveToBringKey : MonoBehaviour
{
    [SerializeField] public GameObject getKeyObjective = null;
    [SerializeField] public GameObject bringKeyToDoorObjective = null;
    // Start is called before the first frame update
    [SerializeField] private Animator arrow1 = null;
    [SerializeField] private Animator arrow2 = null;
    [SerializeField] private Animator arrow3 = null;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("doorKey")){
            getKeyObjective.SetActive(false);
            bringKeyToDoorObjective.SetActive(true);
            gameObject.SetActive(false);
            arrow1.Play("Arrow_rotate", 0, 0.0f);   
            arrow2.Play("Arrow2_rotate", 0, 0.0f);   
            arrow3.Play("Arrow3_rotate", 0, 0.0f);   
        }
    }    
}
