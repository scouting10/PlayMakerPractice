using UnityEngine;

public class PlayerController : MonoBehaviour {

	private float SPEED_X = 10;
	private float SPEED_Z = 10;
	private Rigidbody _rb;

	void Start()
	{
		_rb = GetComponent<Rigidbody>();
	}

	void Update()
	{

		float forward = Input.GetAxis("Vertical");
		float horizontal = Input.GetAxis("Horizontal");

		if(Input.GetKey("up"))
		{
			MoveToUp(forward );
		}
		if(Input.GetKey("right"))
		{
			MoveToRight(horizontal);
		}
		if(Input.GetKey("left"))
		{
			MoveToLeft(horizontal);
		}
		if(Input.GetKey("down"))
		{
			MoveToDown(forward );
		}
	}

	void MoveToUp(float forward){
		_rb.AddForce(0,0,forward * SPEED_Z,ForceMode.Impulse);
	}
	void MoveToRight(float horizontal){
		_rb.AddForce(horizontal * SPEED_X,0,0, ForceMode.Impulse);
	}
	void MoveToLeft(float horizontal){
		_rb.AddForce(horizontal * SPEED_X,0,0, ForceMode.Impulse);
	}
	void MoveToDown(float forward){
		_rb.AddForce(0,0,forward * SPEED_Z, ForceMode.Impulse);
	}


}
