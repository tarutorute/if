using UnityEngine;

public class TestIf : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        int score = 120;

        if (score >= 100)
        {
            Debug.Log("クリア！");
        }

        else
        {
            Debug.Log("残念！");
        }
    }
}
