using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDevice : MonoBehaviour
{
	void Start()
	{
		GetComponent<TMPro.TMP_Text>().text += Global.isMobile ? "Mobile" : "PC";
	}
}
