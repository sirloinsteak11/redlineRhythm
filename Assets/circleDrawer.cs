using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleDrawer : MonoBehaviour
{

    [SerializeField] LineRenderer circleRenderer;
    public int steps;
    public float radius;
    public int stepsChecker;
    public float radiusChecker;

    // Start is called before the first frame update
    void Start()
    {
        drawCircle(steps, radius);
        stepsChecker = steps;
        radiusChecker = radius;
    }

    // Update is called once per frame
    void Update()
    {
        if (steps != stepsChecker) 
        {
            drawCircle(steps, radius);
        }
        if (radius != radiusChecker) 
        {
            drawCircle(steps, radius);
        }
       stepsChecker = steps;
       radiusChecker = radius;
    }

    void drawCircle(int steps, float radius) 
    {
        circleRenderer.positionCount = steps;

        for (int currentStep=0; currentStep<steps; currentStep++)
        {
            float circumferenceProgress = (float)currentStep/(steps-1);
 
            float currentRadian = circumferenceProgress * 2 * Mathf.PI;
            
            float xScaled = Mathf.Cos(currentRadian);
            float yScaled = Mathf.Sin(currentRadian);
 
            float x = radius * xScaled * 4;
            float y = radius * yScaled * 4;
            float z = 0;
 
            Vector3 currentPosition = new Vector3(x,y,z);
 
            circleRenderer.SetPosition(currentStep,currentPosition);
        }
    }
}
