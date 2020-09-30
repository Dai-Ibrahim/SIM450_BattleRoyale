using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
	public float rotFl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(gameObject.tag == "x")
		{
			 transform.localEulerAngles = new Vector3(-Mathf.PingPong(Time.time*40, rotFl), 0, 0); 

		}
		
		else if(gameObject.tag == "y")
		{
		 	transform.localEulerAngles = new Vector3(0, 0,-Mathf.PingPong(Time.time*40, rotFl)); 

		}
		 

        
    }
}
