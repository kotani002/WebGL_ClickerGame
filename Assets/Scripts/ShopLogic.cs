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
}
