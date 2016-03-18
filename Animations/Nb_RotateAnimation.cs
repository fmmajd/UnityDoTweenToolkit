using UnityEngine;
using System.Collections;
using DG.Tweening;
using System.IO;

public sealed class Nb_RotateAnimation : Nb_Animation {

	//I don't know if these will be used in the future or not, so maybe we can remove them later
	private Vector3 origin, destination;

	public Nb_RotateAnimation(GameObject obj, float x, float y, float z, float duration){
		origin = new Vector3(obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
		destination = new Vector3 (x, y, z);
		tween = obj.transform.DORotate (destination, duration, RotateMode.LocalAxisAdd);
	}

}
