using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsabelaMovement : MonoBehaviour
{
    //creates variables to store the target positions
    public Transform LeftTarget;
    public Transform RightTarget;

    //stores the current, next, and previous left leg positions
    private Vector3 _leftCurrentPosition;
    private Vector3 _leftNextPosition;
    private Vector3 _leftPreviousPosition;
    
    //stores the current, next, and previous right leg positions
    private Vector3 _rightCurrentPosition;
    private Vector3 _rightNextPosition;
    private Vector3 _rightPreviousPosition;


    //stores the step size and the step height of the character
    public float StepSize;
    public float StepHeight;
    
    

}
