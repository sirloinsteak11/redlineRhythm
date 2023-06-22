using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteObject : MonoBehaviour
{

    [SerializeField] SpriteRenderer noteRend;
    public bindController Binds;
    public bool pressable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (pressable)
        {
            if (noteRend.sortingOrder == 0)
            {
                if (Binds.k1)
                {
                    gameObject.SetActive(false);
                }
            }

            if (noteRend.sortingOrder == 1)
            {
                if (Binds.k2)
                {
                    gameObject.SetActive(false);
                }
            }

            if (noteRend.sortingOrder == 2)
            {
                if (Binds.k3)
                {
                    gameObject.SetActive(false);
                }
            }

            if (noteRend.sortingOrder == 3)
            {
                if (Binds.k4)
                {
                    gameObject.SetActive(false);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "buttonObject")
        {
            pressable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pressable = false;
    }
}
