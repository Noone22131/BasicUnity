using UnityEngine;

public class VarialbeExample : MonoBehaviour
{
    //변수 선언
    public int playerScore = 0;
    public float speed = 5.5f;
    public string playerName = "Hero";
    public bool isGameOver = true;


    void Start()
    {
        Debug.Log($"Player Name : {playerName}");
        Debug.Log($"Player Score : {playerScore}");
        Debug.Log($"speed : {speed}");
        Debug.Log($"Is Game Over? : {isGameOver}");
    }
}
