using UnityEngine;
using UnityEngine.UI;       // Slider を使うため
using TMPro;                // TextMeshPro を使うため

public class Member : MonoBehaviour
{
    [Header("HP 表示用スライダー")]
    public Slider hpSlider;

    [Header("HP 表示用テキスト")]
    public TMP_Text hpText;

    [Header("キャラクターのHP")]
    public int maxHp = 100;
    public int hp = 100;

    void Start()
    {
        // 初期設定
        if (hpSlider != null)
        {
            hpSlider.maxValue = maxHp;
            hpSlider.value = hp;
        }

        if (hpText != null)
        {
            hpText.text = "HP: " + hp.ToString();
        }
    }

    void Update()
    {
        // HP 値を反映
        if (hpSlider != null)
        {
            hpSlider.value = hp;
        }

        if (hpText != null)
        {
            hpText.text = "HP: " + hp.ToString();
        }

        // デバッグ用（HP が毎秒1ずつ減る例）
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hp -= 10;
            if (hp < 0) hp = 0;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Rが押されたよ！");
            hp += 10;
            if (hp > maxHp) hp = maxHp;
        }

    }
}
