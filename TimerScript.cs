using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    // Start is called before the first frame update
    private float Timer;
    public Text TimerText;

    private float num1;
    void Quit()
    {
        UnityEngine.Application.Quit();
    }
        void Start()
    {
        Timer = 30;
    }

    // Update is called once per frame
    void Update()
    {
        num1 = Mathf.Floor(Timer); //小数点以下は切り捨て
        TimerText.text = "Time:"+ num1.ToString();

        if(Timer >= 0)
        {
            Timer -= Time.deltaTime * 1; //Timerの時間を減らす
        }
        else if(Timer <= 0)
        {
            Timer = 0;
            print("Time Up!!");
            //Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;   // UnityEditorの実行を停止する処理

            Application.Quit();                                // ゲームを終了する処理
        }
    }
}
