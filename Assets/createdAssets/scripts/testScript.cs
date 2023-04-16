using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour
{
    [SerializeField] private Light lighting = null;
    [SerializeField] private Color colors;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public void ChangeMaterial()
    {
        lighting.color = colors;
    }
}
