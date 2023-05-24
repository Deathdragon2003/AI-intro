using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent _agent;
    RaycastHit _hitInfo = new RaycastHit();

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
       
      
        if(Vector3.Distance(_agent.destination, transform.position) < 2f)
        {
            float randomX = Random.Range(-5f, 5f);
            float randomZ = Random.Range(-5f, 5f);
            Vector3 randomPosition = new Vector3(transform.position.x + randomX,transform.position.y,transform.position.z + randomZ);
            _agent.destination = randomPosition;
                                                 
        }
        

    }
}
