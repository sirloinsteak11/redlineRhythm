using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Binds
{
    public bool k1, k2, k3, k4;
}

public class buttonController : MonoBehaviour
{

    [SerializeField] GameObject button1, button2, button3, button4;
    [SerializeField] SpriteRenderer rend1, rend2, rend3, rend4;
    [SerializeField] Color disabledColor, enabledColor;
    Binds playerBinds = new Binds();
    public string[] keys = {"d", "f", "k", "l"};

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

        playerBinds.k1 = Input.GetKey(keys[0]);
        playerBinds.k2 = Input.GetKey(keys[1]);
        playerBinds.k3 = Input.GetKey(keys[2]);
        playerBinds.k4 = Input.GetKey(keys[3]);

        if (playerBinds.k1)
        {
            rend1.color = enabledColor;
        } else
        {
            rend1.color = disabledColor;
        }

        if (playerBinds.k2)
        {
            rend2.color = enabledColor;
        }
        else
        {
            rend2.color = disabledColor;
        }

        if (playerBinds.k3)
        {
            rend3.color = enabledColor;
        }
        else
        {
            rend3.color = disabledColor;
        }

        if (playerBinds.k4)
        {
            rend4.color = enabledColor;
        }
        else
        {
            rend4.color = disabledColor;
        }
    }
}
