using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class opencloseDoor1 : MonoBehaviour
{

	public Animator openandclose1;
	public bool open;
	public Transform Player;

	void Start()
	{
		open = false;
	}

	void OnMouseOver()
	{
		{
			if (Player)
			{
				float dist = Vector3.Distance(Player.position, transform.position);
				if (dist < 15)
				{
					if (open == false)
					{
						if (Input.GetMouseButtonDown(0))
						{
							StartCoroutine(opening());
						}
					}
					else
					{
						if (open == true)
						{
							if (Input.GetMouseButtonDown(0))
							{
								StartCoroutine(closing());
							}
						}

					}

				}
			}

		}

	}
	void Update()
	{
		if (Vector3.Distance(Player.position, transform.position) < 2)
		{
			if (open == false)
			{
					StartCoroutine(opening());
				
			}

		}
	}

	private void OnTriggerEnter(Collider other)
	{
		print(other.gameObject.name);
		if (other.gameObject.name == "LeftForeArm")
		{
			print("touched");
			StartCoroutine(opening());
		}
	}

	IEnumerator opening()
	{
		print("you are opening the door");
		openandclose1.Play("Opening 1");
		open = true;
		yield return new WaitForSeconds(.5f);
	}

	IEnumerator closing()
	{
		print("you are closing the door");
		openandclose1.Play("Closing 1");
		open = false;
		yield return new WaitForSeconds(.5f);
	}


}

