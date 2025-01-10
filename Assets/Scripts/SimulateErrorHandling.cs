using System;
using UnityEngine;
namespace Assignment29
{
    //part5
    public class SimulateErrorHandling : MonoBehaviour
    {
        int playerScore = 100;
        int diviser = 0;
        void Start()
        {
            try
            {
                int totalScore = playerScore / diviser;
                Debug.Log("Attempting to calculate score multiplier...");
            }
            catch (DivideByZeroException)
            {
                Debug.Log("Error: Division by zero occurred while calculating score multiplier.");
            }
            //finally>> in the all status enter finally
            finally
            {
                Debug.Log("Score calculation complete. Cleaning up resources.");
            }
        }
    }
}