# シンプルコインプッシャー

![CoinPusherGif](https://i.gyazo.com/a8630abbea68abda8ad812180f54ff53.gif)

Unityで作る簡単コインプッシャープロジェクト

ワークショップ用です。

## 作業の手順

1. コインを作る
  * 物理挙動 rigidbody
  * 物理マテリアル physicsMaterial
  * 色つけ Material
2. 土台を作る
3. コインを生成させる
  * Spawner.cs
    * Instantiate
4. プッシャーを作る
  * Pusher.cs
    * rigidbody.Moveposition
    * Mathf.Sin
5. つっかえ棒作る
6. リムーバーを作る
  * Remover.cs
    * OnTriggerEnter
7. スコアを作る
  * Score.cs
8. スコアを表示させる
  * Text
9. スコアリムーバーを作る
  * ScoreRemover.cs

This project refer to http://www.nicovideo.jp/watch/sm12948504

次のステップ（参考）: [here](./nextstep_reference.md)
