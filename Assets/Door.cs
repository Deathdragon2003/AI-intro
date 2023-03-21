using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    //
    public float WaitTime = 3f;
    public float Speed = 5f;
    public Vector3 PositionDelta = Vector3.zero;

    //fields
    private Vector3 _closedPosition;
    private Vector3 _openPosition;

    void Start()
    {
        _closedPosition = transform.position;
        _openPosition = _closedPosition + PositionDelta;
        StartCoroutine(OpenClose());
    }

 
    IEnumerator OpenClose()
    {
        bool isOpen = false;
        Vector3 goal = _openPosition;
        while(true)
        {
        
            if(Vector3.Distance(transform.position, goal) < 0.1f)
            {
                isOpen = !isOpen;
                if(isOpen)
                {
                    goal = _closedPosition;
                }
                else
                {
                    goal = _openPosition;
                }


                yield return new WaitForSeconds(WaitTime);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position,goal,Speed * Time.deltaTime);
                yield return null; //wait for 1 frame
            }
         }
    }
}