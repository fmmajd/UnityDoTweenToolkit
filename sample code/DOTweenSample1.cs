using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DOTweenSample : MonoBehaviour{

	//starts a move animation at the start of the scene, or when this object is created
	void Start(){
		//args: GameObject obj, float x, float y, float duration
		INBCommand com = new Nb_MoveAnimation(gameobject, 3, 4, 2.5f);
		com.execute();
	}

	void Update(){}

}
