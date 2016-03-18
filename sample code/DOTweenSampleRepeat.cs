using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DOTweenSampleRepeat : MonoBehaviour{

	private INBCommand com;

	//starts a move animation at the start of the scene, or when this object is created
	void Start(){
		//args: GameObject obj, float x, float y, float duration
		com = new Nb_MoveAnimation(gameobject, 3, 4, 2.5f);
	}

	void Update(){
		if(/*Input is detected*/){
			//repeats the animation 4 times
			//change 4 to your number
			com.repeat(4);
		}
	}

}
