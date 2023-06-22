using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteController : MonoBehaviour
{

    public GameObject[] notes;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            notes[i] = GetComponentInChildren<GameObject>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
