using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : MonoBehaviour
{
    [SerializeField] private string lastClickedButton;
    [SerializeField] private string previousLastClickedButton;
    // Start is called before the first frame update
    [SerializeField] private GameObject Purple;
    [SerializeField] private GameObject Orange;
    [SerializeField] private GameObject Green;
    [SerializeField] private GameObject DarkBlue;
    
    void Start()
    {
        Purple.SetActive(false);
        Orange.SetActive(false);
        Green.SetActive(false);
        DarkBlue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setlastClickedButton(string clickedButton)
    {
        previousLastClickedButton = lastClickedButton;
        lastClickedButton = clickedButton;
        checkIfNewButtonAvailable();
    }

    private void checkIfNewButtonAvailable()
    {
        if (lastClickedButton == "Blue" && previousLastClickedButton == "Red" ||
            previousLastClickedButton == "Blue" && lastClickedButton == "Red")
        {
            Purple.SetActive(true);
            lastClickedButton = null;
            previousLastClickedButton = null;
        }
        else if (lastClickedButton == "Red" && previousLastClickedButton == "Yellow" ||
                 previousLastClickedButton == "Red" && lastClickedButton == "Yellow")
        {
            Orange.SetActive(true);
            lastClickedButton = null;
            previousLastClickedButton = null;
        }
        else if (lastClickedButton == "Blue" && previousLastClickedButton == "Yellow" ||
                 previousLastClickedButton == "Blue" && lastClickedButton == "Yellow")
        {
            Green.SetActive(true);
            lastClickedButton = null;
            previousLastClickedButton = null;
        }
        else if (lastClickedButton == "Purple" && previousLastClickedButton == "Blue" || lastClickedButton == "Blue" &&
                 previousLastClickedButton == "Purple")
        {
            DarkBlue.SetActive(true);
            lastClickedButton = null;
            previousLastClickedButton = null;
        }
    }

}
