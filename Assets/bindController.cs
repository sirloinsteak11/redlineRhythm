using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bindController : MonoBehaviour
{
    public string[] keybinds = { "d", "f", "k", "l" };
    public bool k1, k2, k3, k4;

    private void Update()
    {
        k1 = Input.GetKey(keybinds[0]);
        k2 = Input.GetKey(keybinds[1]);
        k3 = Input.GetKey(keybinds[2]);
        k4 = Input.GetKey(keybinds[3]);
    }
}
