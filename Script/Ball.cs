using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public Rigidbody2D rb;
	public CircleCollider2D col;
	public static Ball Instance;

	public Vector3 pos; //{ get { return transform.position; } }



	Camera cam;

	//public Ball ball;
	public Trajectory trajectory;
	[SerializeField] float pushForce = 6f;

	bool isDragging = false;

	Vector2 startPoint;
	Vector2 endPoint;
	Vector2 direction;
	Vector2 force;
	float distance;


	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		col = GetComponent<CircleCollider2D>();
		cam = Camera.main;
		trajectory = FindObjectOfType<Trajectory>();
		MakeSingleton();
	}
	//---------------------------------------------
	void Update()
	{
		pos = transform.position;
		if (Input.GetMouseButtonDown(0))
		{
			isDragging = true;
			OnDragStart();
		}
		if (Input.GetMouseButtonUp(0))
		{
			isDragging = false;
			OnDragEnd();
		}

		if (isDragging)
		{
			OnDrag();
		}
	}

	void OnDragStart()
	{
		//Ball.Instance.DesactivateRb();
		startPoint = cam.ScreenToWorldPoint(Input.mousePosition);

		
		trajectory.Show();
	}

	void OnDrag()
	{
		endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
		distance = Vector2.Distance(startPoint, endPoint);
		//Debug.Log(distance);
		direction = (startPoint - endPoint).normalized;
		force = direction * pushForce;
		
		//just for debug
		Debug.DrawLine(startPoint, endPoint);

		
		trajectory.UpdateDots(pos, force);
	}

	void OnDragEnd()
	{
		//push the ball
		ActivateRb();

		Push(force);

		trajectory.Hide();
		
		
	}
	//End-----------------------------------

	void MakeSingleton()
    {
		if (Instance == null)
        {
			Instance = this;
        }
    }

	public void Push(Vector2 force)
	{
		rb.AddForce(force, ForceMode2D.Impulse);
		
		
	}

	public void ActivateRb()
	{
		rb.isKinematic = false;
	}

	public void DesactivateRb()
	{
		rb.velocity = Vector3.zero;
		rb.angularVelocity = 0f;
		rb.isKinematic = true;
	}
}