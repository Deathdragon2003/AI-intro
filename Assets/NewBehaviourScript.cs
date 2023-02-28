using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
/*
    // Update is called once per frame
    void Update()
    {
       bool dKey = Input.GetKeyDown(KeyCode.D);
	   if(dKey == true)
	   {
	   Debug.Log(dKey);
	   Vector3 playerPosition = transform.position;
	   playerPosition.z = playerPosition.z += speed * Time.deltaTime;
	   transform.position = playerPosition;
	   }
    }
	*/ 
	void Update ()
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		//get the main camera
		Camera camera = Camera.main;
		//Camera's forward and right vectors
		Vector3 forward = camera.transform.forward;
		Vector3 right = camera.transform.right;
		//we dont care about up and down
		forward.y = 0f;
		right.y = 0f;
		forward.Normalize();
		right.Normalize();
		Vector3 desiredMoveDirection = (forward * vertical) + (right * horizontal);
		Vector3 moveDir = new Vector3(horizontal,0,vertical) .normalized;
		transform.position += moveDir * speed * Time.deltaTime;
	}
}
