using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
	[SerializeField] Animator walkAnimal;

	[SerializeField] Joystick left;

	void Start()
	{
		walkAnimal = GetComponent<Animator>();
	}

	void Update()
	{
		if(left.unlimitedLocalPositionEnd.x != 0 || left.unlimitedLocalPositionEnd.y != 0)
		{
			walkAnimal.StopPlayback();
		}
		else
		{
			walkAnimal.StartPlayback();
		}
	}
}
