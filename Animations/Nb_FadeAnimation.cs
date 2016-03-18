using UnityEngine;
using System.Collections;
using DG.Tweening;
using System.IO;
using UnityEditor;

public sealed class Nb_FadeAnimation : Nb_Animation {

	public Nb_FadeAnimation(GameObject obj, float alpha, float duration){
		Sequence seq = DOTween.Sequence ();
		foreach(Transform transform in obj.transform){
			SpriteRenderer sprite = transform.GetComponent<SpriteRenderer> ();
			seq.Join (sprite.DOFade (alpha, duration));
		}
		tween = seq;
	}

}
