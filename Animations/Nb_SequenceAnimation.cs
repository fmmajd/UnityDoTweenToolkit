using UnityEngine;
using System.Collections;
using DG.Tweening;
using System.IO;

public sealed class Nb_SequenceAnimation : Nb_Animation {

	private bool playParallel;//if animations should play parallel or in order
	private Sequence sequence;

	public Nb_SequenceAnimation(bool playParallel = false){
		this.playParallel = playParallel;
		sequence = DOTween.Sequence ();
		tween = sequence;
	}

	public void addAnimation(INBAnimationCommands command){
		if (playParallel)
			sequence.Join (command.getAnimation ());
		else
			sequence.Append (command.getAnimation ());
		tween = sequence;
	}

}
