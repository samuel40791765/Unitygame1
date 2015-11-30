using UnityEngine;
using AnimationOrTween;
using System.Collections;

public class EndGame : MonoBehaviour {

	public Trigger trigger = Trigger.OnClick;

	void OnClick ()
	{
		if (enabled && trigger == Trigger.OnClick)
		{
			Application.Quit();
		}
	}
}
