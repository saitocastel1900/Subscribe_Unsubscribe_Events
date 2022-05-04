using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate 
{
    //準備
    public delegate void Del();
    public Del onComplete;
    
    //実行後登録されたメソッドを実行
    public void DateNow()
    {
        Debug.Log("現在の日時"+DateTime.Now);
        onComplete();
    }

    //メソッド内で処理実行後に、登録したメソッドを実行
    public void Method(Del delegateMethod)
    {
        /*処理*/
        
        delegateMethod();
    }
}
