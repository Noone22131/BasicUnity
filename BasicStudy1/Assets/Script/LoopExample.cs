using UnityEngine;

public class LoopExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int counter = 0;
        while(counter <5)
        {
            Debug.Log("While Count : " + counter);
            counter++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
