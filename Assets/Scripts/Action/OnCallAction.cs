using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCallAction : MonoBehaviour
{
    private void Start()
    {
        var time = new Actionevent();
        time.onComplete += CallBack;
        time.DateNow();
        
        //外部からの実行と代入が駅無くなる
        //time.onComplete();
        //time.onComplete()=CallBack;
      
        /*
        time.Method(CallBack); 
         */
    }
    void CallBack()
    {
        Debug.Log("処理終了!");
    }
}
