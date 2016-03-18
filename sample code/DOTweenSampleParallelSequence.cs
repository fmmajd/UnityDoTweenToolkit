using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DOTweenSampleParallelSequence : MonoBehaviour{

	//starts a move animation at the start of the scene, or when this object is created
	void Start(){
		//args: GameObject obj, float x, float y, float duration
		INBCommand com = new Nb_SequenceAnimation(true);//true makes the sequence animations play parallel
		com.addAnimation(new Nb_MoveAnimation(gameobject, 3, 4, 2.5f));
		com.addAnimation(new Nb_RotateAnimation(gameobject, 3, 4, 1, 2.5f));
		com.execute();
	}

	void Update(){}

}
