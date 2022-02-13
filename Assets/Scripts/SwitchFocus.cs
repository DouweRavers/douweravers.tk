using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SwitchFocus : MonoBehaviour
{
    [SerializeField]
    Transform[] targets;
    CinemachineVirtualCamera vcam;

    int activeTarget = 0;

    void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
    }

    void Update()
    {
        if (Input.GetKeyDown("left")) GoPrevious();
        if (Input.GetKeyDown("right")) GoNext();
    }

    public void GoNext() {
        activeTarget++;
        if (activeTarget == targets.Length) activeTarget = 0;
        vcam.LookAt = targets[activeTarget];
        vcam.Follow = targets[activeTarget];
    }

    public void GoPrevious() {
        activeTarget--;
        if (activeTarget < 0) activeTarget = targets.Length -1;
        vcam.LookAt = targets[activeTarget];
        vcam.Follow = targets[activeTarget];
    }
}
