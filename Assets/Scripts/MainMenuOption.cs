using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MainMenuOption : MonoBehaviour {
	public GameObject icon, meshButton;
	public UnityEvent OnFocusGained, OnFocusLost;

	void Start() {
		FocusLost();
	}

	public void FocusGained() {
		icon.SetActive(false);
		meshButton.GetComponent<MeshButton>().Active = false;
		OnFocusGained.Invoke();
	}

	public void FocusLost() {
		icon.SetActive(true);
		meshButton.GetComponent<MeshButton>().Active = true;
		OnFocusLost.Invoke();
	}
}
