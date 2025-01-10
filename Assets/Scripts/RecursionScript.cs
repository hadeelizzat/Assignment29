using UnityEngine;

public class RecursionScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log(FibonacciRecursive(10));
        Debug.Log(FibonacciRecursive(30));
        Debug.Log(FibonacciIterative(10));
        Debug.Log(FibonacciIterative(30));
    }
    int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }
    int FibonacciIterative(int n)
    {
        if (n <= 1) return n;

        int a = 0;
        int b = 1;
        int result = 0;

        for (int i = 2; i <= n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }

        return result;
    }
}
