using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    private int Score; //変数
    Text ScoreText; //特典の文字の変数
    //public GameObject Basket;
    void Start()
    {
        ScoreText = GameObject.Find("Text").GetComponent<Text>(); //ScoreTextをTextにする
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score" + Score.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Apple")
        {
            Score += 100;
        }
    }
}


//CanvasのTextに書く
//Capsule Collider とBox Colliderの is Triggerにチェックを入れる
//Add TagでTag指定をする
//BasketにもScoreScriptを入れる（無くてもいいかも）
