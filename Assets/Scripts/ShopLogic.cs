using UnityEngine;

public class ShopLogic : MonoBehaviour
{
    // 練習問題：クリックされたらScoreIncreaseを+1して、Scoreを-10する関数
    // ※もしもScoreが10以下なら 押しても反応しない（ScoreIncreaseを+1しない）
    // Buttonから呼び出したいのでアクセス修飾子はpublicにすること
    public void AddScoreIncrease()
    {
        if(ClickData.instance.Score < 10)
        {
            // 処理を中断する
            return;
        }
        ClickData.instance.ScoreIncrease += 1;
        ClickData.instance.Score -= 10;
    }

    public void AddGranm()
    {
        if(ClickData.instance.Score < 100)
        {
            // 処理を中断する
            return;
        }

        if(ClickData.instance.GranmaBuyFlag == false)
        ClickData.instance.GranmaBuyFlag = true;

        ClickData.instance.GranmaBuyCount += 1;
        ClickData.instance.Score -= 100;
    }

    // やりたいこと：30秒に1回 自動クリックが実行される
    // private float型 変数名：ElapsedTime
    private float ElapsedTime;

    private void Update()
    {
        // 課題：Updateの処理を ばあちゃんを買った後にしか動かさないようにする

        // 4.ばあちゃん買うボタンを追加する
        // EX.ばあちゃんを買った数*スコア分 スコアを加算する
        // EX2.ばあちゃんの待機時間を変数にする

        if(ClickData.instance.GranmaBuyFlag == false)
        {
            return;
        }

        // deltaTime : 前回のFrameからどのくらい時間が経過したか
        ElapsedTime += Time.deltaTime;

        // もしもElapsedTimeが3秒以上だったら
        if(ElapsedTime >= 3)
        {
            // スコアに＋１をする
            ClickData.instance.Score += 1 * ClickData.instance.GranmaBuyCount;
            ElapsedTime -= 3;
        }
    }
}
