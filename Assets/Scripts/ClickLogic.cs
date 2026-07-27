using UnityEngine;

public class ClickLogic : MonoBehaviour
{
    // スコアを増加させる関数
    // 関数名 AddScore
    // ClickData.Scoreを加算させる処理にする
    public void AddScore()
    {
        // ClickData.Scoreを加算させる処理
        ClickData.instance.Score += ClickData.instance.ScoreIncrease;
        // Scoreに対してScore＋ScoreIncreaseをしている
    }
}
