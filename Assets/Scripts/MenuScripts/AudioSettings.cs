using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject AudioMenu;
    public GameObject rightHand;
    public Button button;
    private bool hasBeenTriggered = false;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
    }

    public void TriggerButton()
    {
        if (!hasBeenTriggered)
        {
            button.onClick.Invoke();
            MainMenu.SetActive(false);
            AudioMenu.SetActive(true);
            hasBeenTriggered = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (rightHand.GetComponent<Collider>().bounds.Intersects(button.GetComponent<Collider>().bounds))
        {
            if (!hasBeenTriggered)
            {
                TriggerButton();
            }
        }
        else
        {
            hasBeenTriggered = false;
        }
    }
}
