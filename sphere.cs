using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour {

	public float move_speed; //to enhance the objects moving speed since its really slow by default

	// Use this for initialization
	void Start () { //this will happen once at the start
		move_speed = 3f; //we knew how to change this cuz if you click the object, look at the bottom right,
		//itll show you all your declared variables and let you play the game and change it as you like
		//that way you can figure out your ideal speed.
	}
	
	// Update is called once per frame
	void Update () { //this will happen for every frame

		//In the project settings -> input -> axis folder has all the directions you can move
		//		print(Input.GetAxis("Horizontal")); //so we used Input.GetAxis("WhicheverAxisYouAreControlilng")

		//the f is for float number -> keeping a consistent movement
		//could make the x -> -1f*Time.deltaTime (which would move it in the opposite x direction)
		//Now we can move left/right and up/down (not y, but z)
		transform.Translate(move_speed*Input.GetAxis("Horizontal")*Time.deltaTime, 0f, move_speed*Input.GetAxis("Vertical")*Time.deltaTime); //x,y,z how much we are moving in x direction


	}
}
