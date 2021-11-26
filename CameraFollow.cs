using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target; //ターゲットへの参照
    private Vector3 offset; //相対座標
    void Start()
    {
        //自分自身とtargetとの相対距離を求める
        offset = GetComponent<Transform>().position - target.position;
        //offsetはターゲットとカメラの相対距離、　それはターゲットの座標と
        //GetComponentはエディタの中の右側にある一覧、その中のTransformのpositionの数字を取ってきている
    }

    // Update is called once per frame
    void Update()
    {
        // 自分自身の座標に、targetの座標に相対座標を足した値を設定する
       　GetComponent<Transform>().position = target.position + offset;


        float posx = target.transform.position.x;
        float posy = target.transform.position.y;
        float posz = target.transform.position.z;

        //transform.position = new Vector3(posx　+10, posy　+10 , posz -10);
        //playerが動くと地面が動くコードであって、付いてくる感じではない
    }
}
