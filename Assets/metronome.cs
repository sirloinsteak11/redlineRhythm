using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metronome : MonoBehaviour
{

    public audioController audioController;
    public SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool oddeven = Mathf.FloorToInt(audioController.songPositionInBeats) % 2 == 0;

        renderer.enabled = oddeven;
    }
}
