using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assigment29.part6
{
    public class UnitySpecificScript : MonoBehaviour
    {
    // Start is called before the first frame update

    private GameObject targetObject;
    private GameObject Joker;
    private Light light;
    void Start()
    {
        Debug.Log("Game started!");
        targetObject = GameObject.Find("TargetObject");
        Joker = GameObject.FindGameObjectWithTag("Joker");
        light = GameObject.FindObjectOfType<Light>();

        if (targetObject == null) Debug.Log("No TargetObject found."); else Debug.Log(Joker.name);
        if (Joker == null) Debug.Log("No Joker Object found."); else Debug.Log(Joker.name);
        if (light == null) Debug.Log("No light Object found."); else Debug.Log(Joker.name);


    }
    private void OnEnable()
    {
        Debug.Log("GameObject Enabled");

    }
    /// <summary>
    /// This function is called when the behaviour becomes disabled or inactive.
    /// </summary>
    private void OnDisable()
    {
        Debug.Log("GameObject Disabled");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.D))
        {
            targetObject.gameObject.SetActive(false);
            print("TargetObject deactivated!");
        }
    }
    }
}
