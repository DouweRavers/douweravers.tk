using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MeshButton : MonoBehaviour {
	public bool Active {
		get { return active; }
		set {
			active = value;
			if (!active) outline.enabled = false;
		}
	}
	bool active = true;
	public Animator Logo;
	public UnityEvent OnPressed, OnHover, OnExit;
	Outline outline;
	void Start() {
		outline = GetComponent<Outline>();
		outline.enabled = false;
	}

	void OnMouseDown() {
		if (!active) return;
		Logo.SetBool("Shown", false);
		OnPressed.Invoke();
	}

	void OnMouseEnter() {
		if (!active) return;
		Logo.SetBool("Shown", true);
		outline.enabled = true;
		OnHover.Invoke();
	}

	void OnMouseExit() {
		if (!active) return;
		Logo.SetBool("Shown", false);
		outline.enabled = false;
		OnExit.Invoke();
	}
}
