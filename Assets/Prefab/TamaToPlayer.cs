using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamaToPlayer : MonoBehaviour
{

    //プレイヤーオブジェクト
    public GameObject player;
    //弾のプレハブオブジェクト
    public GameObject tama;

    //一秒ごとに弾を発射するためのもの
    private float targetTime = 1.0f;
    private float currentTime = 0;

    // Update is called once per frame
    void Update()
    {
        //一秒経つごとに弾を発射する
        currentTime += Time.deltaTime;
        if (targetTime < currentTime)
        {
            currentTime = 0;
            //敵の座標を変数posに保存
            var pos = this.gameObject.transform.position;
            //弾のプレハブを作成
            var t = Instantiate(tama) as GameObject;
            //弾のプレハブの位置を敵の位置にする
            t.transform.position = pos;
            //敵からプレイヤーに向かうベクトルをつくる
            //プレイヤーの位置から敵の位置（弾の位置）を引く
            Vector2 vec = player.transform.position - pos;
            //弾のRigidBody2Dコンポネントのvelocityに先程求めたベクトルを入れて力を加える
            t.GetComponent<Rigidbody2D>().velocity = vec;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamaToPlayerFollow : MonoBehaviour
{
    //プレイヤー
    public GameObject player;
    //弾のプレハブ
    public GameObject tama;
    //弾を一秒ごとに打ち出す
    private float targetTime = 1.0f;
    private float currentTime = 0;
    //弾を保存しておくリスト
    private List<GameObject> list = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {
        //弾を一秒ごとに打ち出すためのもの
        currentTime += Time.deltaTime;
        if (targetTime < currentTime)
        {
            currentTime = 0;
            //敵の位置を保存
            var pos = this.gameObject.transform.position;
            //弾のプレハブを作成
            var t = Instantiate(tama) as GameObject;
            //リストに弾を保存しておく
            list.Add(t);
            //弾の初期位置を敵の位置にする
            t.transform.position = pos;
        }
        //リストから一つずつ弾を取り出してベクトルの向きを修正する
        foreach (var l in list)
        {
            //弾のvelocityにベクトルを入れる
            //弾からプレイヤーへのベクトルを求めて、正規化し任意の速さ3をかける
            l.GetComponent<Rigidbody2D>().velocity = (player.transform.position - l.transform.position).normalized * 3;
        }
    }
}