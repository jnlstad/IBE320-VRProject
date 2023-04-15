using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreboardTimer : MonoBehaviour
{
// Place this script in the XR Origin Object, you might also need a capsule collider there

// Make the GameObjects into the Layer PlayerTrigger, and make it so the player can in fact interact with them.
//Also, isTrigger ON
    [SerializeField] public GameObject beginning = null;
    [SerializeField] public GameObject roomEscape = null;
    [SerializeField] public GameObject mazeEscape = null;
    [SerializeField] public GameObject roomBlocker = null;


    private float stopwatch = 0;
    private string roomEscapeTime = "";
    private string mazeEscapeTime = "";
    private bool timer = false;

    // Start is called before the first frame update
    void Start()
    {
        // stopwatch = 0;
    }

    // Update is called once per frame

    void Update()
    {
        if (timer){
            stopwatch += 1 * Time.deltaTime;
            Debug.Log(stopwatch.ToString("#.##"));
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject == beginning)
        {
            beginning.SetActive(false);
            timer = true;
            roomBlocker.SetActive(true);
        }

        if(other.gameObject == roomEscape)
        {
            roomEscapeTime = stopwatch.ToString("#.##");
            Debug.LogError("You escaped the room in " + roomEscapeTime);
            roomEscape.SetActive(false);
        }

        if(other.gameObject == mazeEscape)
        {
            mazeEscapeTime = stopwatch.ToString("#.##");
            Debug.LogError("You escaped the maze in " + mazeEscapeTime);
            mazeEscape.SetActive(false);
            timer = false;
        }
    }
}