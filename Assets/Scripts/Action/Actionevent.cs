using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Actionevent 
{
    //delegateと比べて一行打つ量が減った
    //eventで
    public event Action onComplete=null;

    public void DateNow()
    {
        Debug.Log("現在の日時" + DateTime.Now);
        
        //nullチェック
        if(onComplete != null){ 
            onComplete();
        }
    }

    //メソッド内で処理実行後に、登録したメソッドを実行
    public void Method(Action actionMethod)
    {
        /*処理*/

        actionMethod();
    }
}
