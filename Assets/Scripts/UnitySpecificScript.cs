using UnityEngine;
namespace Assignment29
{
    //part6
    public class UnitySpecificScript : MonoBehaviour
    {
        public GameObject targetObject;
        public GameObject joker;
        public Light lightType;
        void OnEnable()
        {
            print("GameObject Enabled");
        }
        void Start()
        {
            print("Game started!");
            targetObject = GameObject.Find("TargetObject");
            joker = GameObject.FindGameObjectWithTag("Joker");
            lightType = GameObject.FindObjectOfType<Light>();
            if (targetObject != null)
            {
                print("Found object by name: TargetObject");
            }
            if (targetObject == null)
            {
                print("No TargetObject found.");
            }
            if (joker != null)
            {
                print("Found object by tag: Joker");
            }
            if (joker == null)
            {
                print("No Joker object found.");
            }
            if (lightType != null)
            {
                print($"Found object of type Light: {lightType.name}");
            }
            if (lightType == null)
            {
                print($"No light object found.");

            }
        }

        void Update()
        {
            if (targetObject != null)
            {
                if (Input.GetKeyDown(KeyCode.K))
                {
                    targetObject.SetActive(false);
                    print("TargetObject deactivated!");
                }
            }
        }
        void OnDisable()
        {
            print("GameObject Disabled");
        }
    }
}