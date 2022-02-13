using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyToClipboard : MonoBehaviour
{
    public void CopyStringToClipboard(string text) {
        GUIUtility.systemCopyBuffer = text;
    }
}
