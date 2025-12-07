using UnityEngine;
using TMPro;

public class Member2 : MonoBehaviour
{
    int hp = 30;
    public TextMeshProUGUI HPText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateHPText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage(5);
        }
    }

    void Damage(int amount)
    {
        hp -= amount;
        Debug.Log("åªç›ÇÃHPÇÕ" + hp);

        UpdateHPText();

        if (hp <= 0)
        {
            Die();
        }
    }

    void UpdateHPText()
    {
        HPText.text = "HP: " + hp;
    }

    void Die()
    {
        Debug.Log("ì|ÇÍÇΩÅI");
    }
}
