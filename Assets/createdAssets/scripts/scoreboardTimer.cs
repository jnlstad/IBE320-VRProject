using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreboardTimer : MonoBehaviour
{
// Place this script in the XR Origin Object, you might also need a capsule collider there

// Make the GameObjects into the Layer PlayerTrigger, and make it so the player can in fact interact with them.
//Also, isTrigger ON
    [SerializeField] public GameObject beginning = null;
    [SerializeField] public GameObject roomEscape = null;
    [SerializeField] public GameObject mazeEscape = null;
    [SerializeField] public GameObject roomBlocker = null;
    [SerializeField] public TextMeshProUGUI roomExitTimer = null;
    [SerializeField] public TextMeshProUGUI mazeExitTimer = null;


    [SerializeField] public GameObject findKeyTrigger = null;
    [SerializeField] public GameObject obtainFlashlightObjective = null;
    [SerializeField] public GameObject findDoorObjective = null;
    [SerializeField] public GameObject findKeyObjective = null;
    [SerializeField] public GameObject bringKeyObjective = null;


    [SerializeField] public GameObject flashlight = null;
    [SerializeField] public GameObject flashlightMenu = null;


    [SerializeField] public GameObject globalLight = null;    
    [SerializeField] public GameObject music = null;



    private float stopwatch = 0;
    private string roomEscapeTime = "";
    private string mazeEscapeTime = "";
    private bool timer = false;


    // Start is called before the first frame update

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
            obtainFlashlightObjective.SetActive(true);
        }

        if(other.gameObject == roomEscape)
        {
            roomEscapeTime = stopwatch.ToString("#.##");
            Debug.LogError("You escaped the room in " + roomEscapeTime + " Seconds");
            roomEscape.SetActive(false);
            roomExitTimer.text = "You escaped the room in " + roomEscapeTime + " Seconds";
            obtainFlashlightObjective.SetActive(false);
            findDoorObjective.SetActive(true);
            music.SetActive(true);
        }

        if(other.gameObject == findKeyTrigger)
        {
            findKeyTrigger.SetActive(false);
            findDoorObjective.SetActive(false);
            findKeyObjective.SetActive(true);
        }

        if(other.gameObject == mazeEscape)
        {
            mazeEscapeTime = stopwatch.ToString("#.##");
            Debug.LogError("You escaped the maze in " + mazeEscapeTime + " Seconds");
            mazeEscape.SetActive(false);
            timer = false;
            mazeExitTimer.text = "You escaped the maze in " + mazeEscapeTime + " Seconds";
            music.SetActive(false);
            globalLight.SetActive(true);
            bringKeyObjective.SetActive(false);
            flashlight.SetActive(false);
            flashlightMenu.SetActive(false);
        }
    }
}