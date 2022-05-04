using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEvent = UnityEngine.Events.UnityEvent;

public class CallUnityEvent : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.Events.UnityEvent _unityEvent = new UnityEngine.Events.UnityEvent();

    private void Start()
    {
    //スクリプト上でも関数を登録できます
    //_unityEvent.AddListener(DebugLog("aaaa"));
        StartFunc();
    }

    void StartFunc()
    {
        _unityEvent.Invoke();
    }
}
