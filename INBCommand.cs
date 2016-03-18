using UnityEngine;
using System.Collections;

public interface INBCommand {

	void execute ();
	void pause();
	void resume();
	void stop();
	void repeat (int n);
	void loop ();
	bool isDoing();
	bool isPaused();
	bool isDone();

}
