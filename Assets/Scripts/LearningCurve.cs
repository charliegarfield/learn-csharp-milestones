using UnityEngine;
using Debug;

public class LearningCurve : MonoBehaviour
{
    // A sample Boolean
    private bool hi = false;
    private int count = 0;
    private int count2 = 2;
    private float time = 0;
    private string name = "default";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    /*
     * A class to tell me how things work
     */
    
    /**
     * A summary comment for the start method
     */
    void Start()
    {
        private int[] arr = new int[10];
        var l = new List<string>(new string[] {"test1","test2","test3"});
        var myDict = new Dictionary<string, string> {
            { "key1", "value1" },
            { "key2", "value2" }
        };
            
            foreach(int a in arr){
                Debug.Log(a)
            }
            
            
            
            switch (name)
        {
            case boom:
                break;
            default:
                break;
            
        }
        Debug.Log("Text: " + name);
        Debug.LogFormat("We are <b><i>definitely not</i></b> amused");
        Debug.Log(add(count, count2));
    }

    int Add(int a, int b)
    {
        if (!hi)
        {
            if (count != 0)
            {
                return 0;
            }
            return 0;
        }
        else if (hi)
        {
            continue;
        }

        if (a + b > count2)
        {
            return a + b;
        }
        else if (a+b > count)
        {
            return 100;
        }
        else
        {
            return a - b;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
