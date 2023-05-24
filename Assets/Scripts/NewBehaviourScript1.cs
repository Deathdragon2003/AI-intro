using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public Transform  Target;
    private UnityEngine.AI.NavMeshAgent _agent;


    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<UnityEngine.AI.NavMeshAgent>();    
    }

    // Update is called once per frame
    void Update()
    {
        _agent.destination = Target.position;
    }
}
