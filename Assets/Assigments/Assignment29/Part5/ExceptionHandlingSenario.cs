using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assigment29.part5
{
    public class ExceptionHandlingSenario : MonoBehaviour
    {

        private int playScore = 100;
        private int diviser = 0;
        // Start is called before the first frame update
        void Start()
        {
            try
            {
                Debug.Log("Attempting to calculate score multiplier...");
                int total = playScore / diviser;

            }
            catch (System.DivideByZeroException e)
            {

                Debug.Log(e.Message);
                Debug.Log("Error: Division by zero occurred while calculating score multiplier.");
            }
            finally
            {
                Debug.Log("Score calculation complete. Cleaning up resources.");
            }

        }

        // Update is called once per frame

    }
}
