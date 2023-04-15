using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomReplaceWithMaze : MonoBehaviour
{
    [SerializeField] private GameObject room = null;
    [SerializeField] private GameObject mazeReplacement = null;
    [SerializeField] private GameObject removeTrigger = null;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        room.SetActive(false);
        removeTrigger.SetActive(false);
        mazeReplacement.SetActive(true);
    }
}
