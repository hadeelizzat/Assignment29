using UnityEngine;
namespace Assignment29
//part2
{
    public class CustomObjectExmle : MonoBehaviour
    {
        CustomObject customObject;
        void Start()
        {
            customObject = new CustomObject(1, "Example");
            print(customObject);

        }
    }
}