using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCallDelegate : MonoBehaviour
{
    void Start()
    {
        //引き数なし
        Delegate time = new Delegate();   //インスタンス生成
        time.onComplete += CallBack;      //末尾に処理を追加する(メソッド登録)＝＝複数処理登録可能 *直接代入可能
        time.onComplete += CallBack;
        time.DateNow();
        
        /*
        //引数あり
        var log = new Delegate();
        log.Method(CallBack);
        */
    }

    //登録する関数
    void CallBack()
    {
        Debug.Log("処理終了!");
    }
}
