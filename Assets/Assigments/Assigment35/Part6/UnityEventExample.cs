
using UnityEngine;
using UnityEngine.Events;
namespace Assignment35.Part6
{
    public class UnityEventExample : MonoBehaviour
    {
        // Start is called before the first frame update
        UnityEvent onEventTriggered;
        void Start()
        {
            onEventTriggered = new UnityEvent();
            onEventTriggered.AddListener(DoSomething);
        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                onEventTriggered.Invoke();
            }
        }
        void DoSomething()
        {
            Debug.Log("CThe event has been triggered!");
        }

    }
}