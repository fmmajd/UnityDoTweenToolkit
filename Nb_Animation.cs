using UnityEngine;
using System.Collections;
using DG.Tweening;

public interface INBAnimationCommands : INBCommand {
	Tween getAnimation();
}

public abstract class Nb_Animation :  INBAnimationCommands{
	
	private enum AnimState{NULL, PLAYING, PAUSED};

	protected Tween tween;
	private AnimState state;


	public Nb_Animation(){
		state = AnimState.NULL;
	}

	public Tween getAnimation(){
		return tween;
	}

	public void execute(){
		if (state == AnimState.NULL && tween.IsActive ()) {
			TweenCallback completionListener = finishState;
			tween.Play ().OnComplete (completionListener);
			state = AnimState.PLAYING;
		}
	}

	public void pause(){
		if (state == AnimState.PLAYING) {
			tween.Pause ();
			state = AnimState.PAUSED;
		}
	}

	public void resume(){
		if (state == AnimState.PAUSED) {
			tween.Play ();
			state = AnimState.PLAYING;
		}
	}

	public void stop(){
		if(state == AnimState.PLAYING || state== AnimState.PAUSED){
			tween.Kill ();
			state = AnimState.NULL;
		}
	}

	public void repeat (int n){
		if(state == AnimState.NULL && tween.IsActive () && (n>1 || n==-1)){
			Debug.Log ("salam");
			tween.SetLoops (n);
			tween.Play ();
			state = AnimState.PLAYING;
		}
	}

	public void loop (){
		repeat (-1);
	}

	public bool isDoing(){
		return state == AnimState.PLAYING ? true : false;
	}

	public bool isPaused(){
		return state == AnimState.PAUSED ? true : false;
	}

	public bool isDone(){
		return state == AnimState.NULL ? true : false;
	}

	private void finishState(){
		state = AnimState.NULL;
	}

}