using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonController : MonoBehaviour
{

    [SerializeField] GameObject button1, button2, button3, button4;
    [SerializeField] SpriteRenderer rend1, rend2, rend3, rend4;
    [SerializeField] Color disabledColor, enabledColor;
    public bindController Binds;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

         /*Binds.keybinds[0] = keys[0];
        Binds.bind2 = keys[1];
        Binds.bind3 = keys[2];
        Binds.bind4 = keys[3]; */

        if (Binds.k1)
        {
            rend1.color = enabledColor;
        } else
        {
            rend1.color = disabledColor;
        }

        if (Binds.k2)
        {
            rend2.color = enabledColor;
        }
        else
        {
            rend2.color = disabledColor;
        }

        if (Binds.k3)
        {
            rend3.color = enabledColor;
        }
        else
        {
            rend3.color = disabledColor;
        }

        if (Binds.k4)
        {
            rend4.color = enabledColor;
        }
        else
        {
            rend4.color = disabledColor;
        }
    }
}
