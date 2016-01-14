using UnityEngine;
using System.Collections;

public class PlayerBunny : MonoBehaviour {
    public float runSpeed;
    public float jumpHeight;
    private Rigidbody myRigidBody;
	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            myRigidBody.velocity = new Vector3(runSpeed, myRigidBody.velocity.y, myRigidBody.velocity.z);
        } else if (Input.GetKey(KeyCode.A))
        {
            myRigidBody.velocity = new Vector3(-runSpeed, myRigidBody.velocity.y, myRigidBody.velocity.z);
        }

        if (Input.GetKey(KeyCode.W))
        {
            myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, myRigidBody.velocity.y, runSpeed);
        } else if (Input.GetKey(KeyCode.S))
        {
            myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, myRigidBody.velocity.y, -runSpeed);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, jumpHeight, myRigidBody.velocity.z);
        }
	
	}
}
