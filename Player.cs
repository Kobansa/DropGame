using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    [SerializeField]//この次の変数がエディタ上で編集可能
    private float jumpPower = 400f; //ジャンプ力を入れるための変数

    [SerializeField]//この次の変数がエディタ上で編集可能
    private float moveSpeed = 10f; //移動スピードを入れるための変数

    private bool grounded; //地面に触れているか判断する変数
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Rigidbodyの値を取得してrbという変数に入れる

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow ))//前に進む
        {
            transform.rotation = Quaternion.Euler(0, 0, 0); //rotation　0°に向ける
            transform.position += transform.TransformDirection(Vector3.forward*moveSpeed*Time.deltaTime);
            //前に進む。moveSpeed=10f（速さ）×時間＝距離　距離を求めたいときに使う。また左辺と同じ単位だったら使っても良い　道のりを求める感じ

        }
        if (Input.GetKey(KeyCode.DownArrow))//後ろに進む
        {
            transform.rotation = Quaternion.Euler(0, 180, 0); //y座標を180°回転させる
            transform.position += transform.TransformDirection(Vector3.forward * moveSpeed * Time.deltaTime);
            //後ろに進む。以下同様。回転させているためforwardでも後ろへ行く
            // transform.rotation = Quaternion.Euler(0, 0, 0);
            //transform.position += transform.TransformDirection(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0); //y座標を90°回転させる
            transform.position += transform.TransformDirection(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0); //y座標を90°回転させる
            transform.position += transform.TransformDirection(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded == true)//もし、地面に触れていたなら
                                 //private bool grounded; //地面に触れているか判断する変数
            {
                rb.AddForce(Vector3.up * jumpPower);//ジャンプする
                //private float jumpPower = 400f; //ジャンプ力を入れるための変数
            }
        }
 
    }
    private void OnCollisionEnter(Collision collision)//オブジェクトに触れた処理
    {
        if(collision.gameObject.tag == "Ground")//プレイヤーがGroundというタグに触れたら、、
        {
            grounded = true; //Groundedをtrueにする。Gruondは地面でそれを元に地面に触れていたらの上のifを使う
        }
    }
    private void OnCollisionExit(Collision collision)//オブジェクトから離れた時の処理
    {
        if (collision.gameObject.tag == "Ground")//プレイヤーがGroundというタグから離れたら
        {
            grounded = false; //Groundedをfalseにする。
        }
    }
}

