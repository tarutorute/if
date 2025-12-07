using UnityEngine;

public class Hikaku : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int HitPoint = 5;
        int MagicPoint = 10;

        if (HitPoint <= 0)
        {
            Debug.Log("ゲームオーバー");
        }

        else if (HitPoint >= 1 && MagicPoint >= 10)
        {
            Debug.Log("スキル発動！");
        }

        else
        {
            Debug.Log("通常行動");
        }
    }
}
