using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectsMenu : MonoBehaviour {
	public GameObject StartMenu, UniversityMenu;
	GameObject[] menus;
	void Start() {
		menus = new GameObject[] { StartMenu, UniversityMenu };
		foreach (GameObject menu in menus) menu.SetActive(false);
		StartMenu.SetActive(true);
	}

	void Update() {

	}
}
