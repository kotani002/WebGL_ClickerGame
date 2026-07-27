using UnityEngine;
using TMPro;

public class ClickView : MonoBehaviour
{
    // View 見た目の変化
    // Q : private TextMeshProUGUIが使える型 ScoreText の変数を宣言
    [SerializeField]
    private TextMeshProUGUI ScoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScoreText.text = ClickData.instance.Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = ClickData.instance.Score.ToString();
    }
}
