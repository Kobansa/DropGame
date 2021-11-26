using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleGenerater : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Apple2; //生成するオブジェクト　componentの中にAppleを選択できるようになっている。　空の鍋的な！
    void Start()
    {
        InvokeRepeating("Generate", 4, 26); //"Generate"を1秒経ってから1秒毎に実行する
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Generate()
    {
        float x = Random.Range(-30f, 30f); //xを-30~30の間でランダムに選ぶ
        float y = 30f; //ｙは30にする
        float z = Random.Range(-30f, 30f); //ｚもｘと同じように
       Vector3 position = new Vector3(x, y, z); //positionの座標をxyzにする
        Instantiate(Apple2, position, Quaternion.identity);// オブジェクトをxyzに生成する
    }
}
