using UnityEngine;
using System.Collections;
using DG.Tweening;
using System.IO;

public sealed class Nb_PunchAnimation : Nb_Animation {

	//I don't know if these will be used in the future or not, so maybe we can remove them later
	private Vector3 origin, destination;

	public Nb_PunchAnimation(GameObject obj, float x, float y, int vibrato, float elas, float duration){
		origin = obj.transform.position;
		destination = new Vector3 (x, y, 0);
		tween = obj.transform.DOPunchPosition (destination, duration, vibrato, elas);
	}

}
