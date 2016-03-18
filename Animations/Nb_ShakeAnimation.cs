using UnityEngine;
using System.Collections;
using DG.Tweening;
using System.IO;

public sealed class Nb_ShakeAnimation : Nb_Animation {

	//I don't know if these will be used in the future or not, so maybe we can remove them later
	private Vector3 origin, destination;

	public Nb_ShakeAnimation(GameObject obj, float x, float y, int vibrato, int randomness, float duration, Ease ease = Ease.OutQuad){
		origin = obj.transform.position;
		destination = new Vector3 (x, y, 0);
		tween = obj.transform.DOShakePosition (duration, destination, vibrato, randomness).SetEase (ease);
	}

}
