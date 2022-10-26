using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
	public Rigidbody2D rbShip;
	public Rigidbody2D rbTurret;
	public Camera cam;

	public float startPositionX = 0f; // Starting position for the ship on the X axis
	public float startPositionY = -35f; // Starting position for the ship on the Y axis
	public float shipSpeed = 15f; // Speed multplier for the ship

	Vector2 moveDirection;
	Vector2 mousePos;

	void Start()
	{
		transform.position = new Vector2(startPositionX, startPositionY);
	}

    // Update is called once per frame
    void Update()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");
		moveDirection.y = Input.GetAxisRaw("Vertical");

//		mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

	void FixedUpdate()
	{
		rbShip.MovePosition(rbShip.position + moveDirection * shipSpeed * Time.fixedDeltaTime);

//		Vector2 lookDir = mousePos - rbTurret.position;
//		float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
//		rbTurret.rotation = angle;
	}
}
