using UnityEngine;

public class Me : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Attack(10,3);
    }

    // Update is called once per frame
    void Attack(int damage, int bonus)
    {
        int total = damage + bonus;
        Debug.Log(total + "ダメージ与えた！");
    }
}
