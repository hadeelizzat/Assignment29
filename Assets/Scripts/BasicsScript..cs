using System;
using UnityEngine;
namespace Assignment29
//part1
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            var no = 5;
            var str = String.Empty;
            var status = true;
            str = no % 2 != 0 ? str = "odd" : str = "even";
            Debug.Log($"The number {no} is {str}");
            Debug.Log(DateTime.Today.Date);
            Debug.Log(DateTime.Now.ToLocalTime());
            Debug.Log(DateTime.Now.Day);
        }
    }
}