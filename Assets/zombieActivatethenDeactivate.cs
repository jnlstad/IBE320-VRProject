using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieActivatethenDeactivate : MonoBehaviour
{
    [SerializeField] private GameObject Zombie = null;
    // Start is called before the first frame update

    private float stopwatch = 0;
    private bool timer = false;

    void Update()
    {
        if (timer){
            stopwatch += 1 * Time.deltaTime;
        if (stopwatch > 3){
            Zombie.SetActive(false);
            timer = false;
            }
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            Zombie.SetActive(true); 
            timer = true;
            gameObject.SetActive(false);
        }
    }    
}
