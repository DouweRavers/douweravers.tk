using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class OpenUrl : MonoBehaviour {
	public string url;

	[DllImport("__Internal")]
	private static extern void openWindow(string url);
	public void OpenUrlInNewPage() {
#if !UNITY_EDITOR
		openWindow(url);
#endif
	}
}
