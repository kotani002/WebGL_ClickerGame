using UnityEngine;

public class ClickData : MonoBehaviour
{
    // シングルトン
    public static ClickData instance;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }else
        {
            Destroy(this.transform.gameObject);
        }
    }

    // クリッカーゲームに必要な変数
    public int Score = 0;
    public int ScoreIncrease = 1;
    
    // Shop関連のデータ
    public bool GranmaBuyFlag = false;
    public int GranmaBuyCount = 0;
}