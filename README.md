# Subscribe_Unsubscribe_Events
C#のイベントについて検証したい際に使ったリポジトリです。ご自由にお使いください。

## イベントとは
・処理を発生側と受け取り側に分けるパターン。  
・色々種類があるが有名なものとしてDelegate,event,Action,Funcがある。UnityにはUnityEventと云うものが標準で用意されている。  
### delegate 関数を入れることが出来る型、変数
・コールバック(ボタンを押したときにアニメーションを実行する等)を実装する際に使用。  
・簡単に処理を登録・実行できる  
```
アクセス修飾子 delegate 戻り値の型 デリゲートの型名  
アクセス修飾子 デリゲートの型名 デリゲート変数  
```
### event delegateの修飾子。複数のメソッドが登録可能に

### Action Func  delegateの宣言・準備を少し楽にする
・戻り値あり→Func
・戻り値なし→Action

#### UnityEvent



## 参考資料
https://torikasyu.com/?p=1567  
https://nn-hokuson.hatenablog.com/entry/2021/09/02/114100  
https://ufcpp.net/study/csharp/MiscEventSubscribe.html  
https://kan-kikuchi.hatenablog.com/entry/Delegate
