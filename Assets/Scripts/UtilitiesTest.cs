using UnityEngine;
namespace Assignment29
//part3
{
    public class UtilitiesTest : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(Utilities.Add(1, 3, 5));
            Debug.Log("Hello".RepeatString(8));
        }
    }
}