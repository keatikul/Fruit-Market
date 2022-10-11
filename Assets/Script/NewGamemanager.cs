using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGamemanager : MonoBehaviour
{

	#region Singleton class: GameManager

	public static NewGamemanager Instance;

	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
	}

	#endregion

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

	//---------------------------------------
	void Start()
	{
		cam = Camera.main;
		//Ball.Instance.DesactivateRb();
		//Ball.Instance.DesactivateRb();
	}

	void Update()
	{
		
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

	//-Drag--------------------------------------
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
		direction = (startPoint - endPoint).normalized;
		force = direction * distance * pushForce;

		//just for debug
		Debug.DrawLine(startPoint, endPoint);


		trajectory.UpdateDots(Ball.Instance.pos, force);
	}

	void OnDragEnd()
	{
		//push the ball
		Ball.Instance.ActivateRb();

		Ball.Instance.Push(force);

		trajectory.Hide();
	}

}
