using UnityEngine;
using System.Collections;
using DG.Tweening;
using System.IO;

public sealed class Nb_ScaleAnimation : Nb_Animation {

	//I don't know if these will be used in the future or not, so maybe we can remove them later
	private Vector3 origin, destination;

	public Nb_ScaleAnimation(GameObject obj, float x, float y, float duration){
		origin = obj.transform.position;
		destination = new Vector3 (x, y, 1);
		tween = obj.transform.DOScale (destination, duration);
	}

	public Nb_ScaleAnimation(GameObject obj, float amount, float duration) : this(obj, amount, amount, duration){}
}