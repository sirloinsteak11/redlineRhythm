using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteController : MonoBehaviour
{

    [SerializeField] int noteSpeed;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, -(noteSpeed * Time.deltaTime), 0);
    }
}
