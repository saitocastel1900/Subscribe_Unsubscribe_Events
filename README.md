# Subscribe_Unsubscribe_Events
C#のイベントについて検証したい際に使ったリポジトリです。ご自由にお使いください。

## イベントとは
・処理を発生側と受け取り側に分けるパターン。  
・色々種類があるが有名なものとしてDelegate,event,Action,Funcがある。UnityにはUnityEventと云うものが標準で用意されている。 


### delegate 関数を入れることが出来る型、変数
・コールバック(ボタンを押したときにアニメーションを実行する等)を実装する際に使用。  
・簡単に処理を登録・実行できる  
・+=で関数を追加
```
アクセス修飾子 delegate 戻り値の型 デリゲートの型名  
アクセス修飾子 デリゲートの型名 デリゲート変数  
```


### event delegateの修飾子
・外部からdelegateなどを実行、登録できなくなる(スコープが管理しやすくなる・安全！)
```
アクセス修飾子 event Action or Funcなど アクション変数  
```


### Action Func  delegateの宣言・準備を少し楽にする
```
アクセス修飾子 Action アクション変数  
```
・戻り値あり→Func
・戻り値なし→Action


### UnityEvent C#のeventをクラス化
・Buttonコンポーネントでよく見るやつ
・インスペクタ上に表示される
```
[SerializeField]
private UnityEvent _unityEvent = new UnityEvent();

//スクリプト上で操作したい
_unityEvent.addliner(登録したい関数)        //指定した関数を登録
_unityEvent.invoke()                       //登録されている関数すべてを実行  
_unityEvent.RemoveListener(削除したい関数)  //登録した関数を消す  
_unityEvent.RemoveListener()               //登録した関数すべてを削除  

```
![スクリーンショット 2022-05-04 232238](https://user-images.githubusercontent.com/96648305/166701982-c446b54d-1088-4116-8650-c558373adcd7.png)  
・登録できる関数はPublicである必要がある  
・登録したい関数のデフォルト引数は適用されない  

## 参考資料
https://torikasyu.com/?p=1567  
https://nn-hokuson.hatenablog.com/entry/2021/09/02/114100  
https://ufcpp.net/study/csharp/MiscEventSubscribe.html  
https://kan-kikuchi.hatenablog.com/entry/Delegate
