﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAnimation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	private AnimationBob animationHandler;

	[Header("ResizeButton")]
	public bool buttonAnimation;
	public float scaleAnimationTime;
	public Vector2 endScale;
	public Vector2 startScale;

	private void Start()
	{
		animationHandler = GameObject.Find("AnimationHandler").GetComponent<AnimationBob>();
	}

	public void Resize(Vector2 size)
	{
		if (buttonAnimation)
		{
			LeanTween.scale(this.gameObject, size,scaleAnimationTime);
		}
	}

	public void ResetSize()
	{
		LeanTween.scale(this.gameObject, endScale, scaleAnimationTime);
	}

	//<summary>
	//Button events
	#region event data
	public void OnPointerEnter(PointerEventData eventData)
	{
		Resize(startScale);
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		Resize(endScale);
	}

	#endregion
}
