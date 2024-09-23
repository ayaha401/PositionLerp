# PositionLerp
オブジェクトの位置をスライダーの割合で移動させるスクリプト<br>

https://github.com/user-attachments/assets/60bf6678-8ae8-46b2-a8bd-a0a2dda0e8f6

# 導入方法
* unitypackageをダウンロードして使う

# 動作確認済みバージョン
Unity 2022.3.2f1

# 使い方
![image](https://github.com/user-attachments/assets/396187f9-bd00-4acd-8cdc-1ee444c9946e)<br>
動かしたいオブジェクトに`PositionLerp`を張り付ける<br>
`StartPos`、`EndPos`のパラメータの上で右クリックするとオブジェクトの現在位置で位置を設定できるので設定する<br>
`LerpRate`でオブジェクトが`StartPos`、`EndPos`で線形補間されて移動します。<br>

UnityをPlayしていなくてもスライダーの割合に応じた位置にオブジェクトが移動します。<br>
UnityのAnimationでこのスライダーを動かすことでオブジェクトを0～1の割合で動かせます。<br>
例として教室のドアなど、毎回同じ始点と終点を持つオブジェクトの制御に役立ちます。<br>

# 不具合
未確認
