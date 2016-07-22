using UnityEngine;
using System.Collections;

public class bunnyController : MonoBehaviour {

    private Rigidbody2D myRigidBody;
    public float bunnyJumpForce = 500f;
    private Animator MyAnim;


	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
        MyAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if ( Input.GetButtonUp("Jump") )
        {
            myRigidBody.AddForce(transform.up * bunnyJumpForce);
        }
        MyAnim.SetFloat("vVelocity", myRigidBody.velocity.y);
        //MyAnim.SetFloat("vVelocity", Mathf.Abs( myRigidBody.velocity.y));
    }
}
