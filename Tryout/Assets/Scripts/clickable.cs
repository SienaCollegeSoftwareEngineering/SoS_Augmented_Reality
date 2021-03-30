using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/**
 * If put on an object, will allow the object to act as a button. 
 * Once attached a button onClick() will appear in the properties and 
 * the actions within the onClick() will run when clicked on.
 * 
 * @author Nevno48
 * @version 6/21/19
 */
public class clickable : MonoBehaviour
{
    //This is the object to click on as a button
    public GameObject clickableObject;
    //This is to have a graphical drop down onClick() event in the properties window, like a button
    public UnityEvent OnClick = new UnityEvent();

    /**
     * Description: This method runs once when the app runs
     * 
     */
    void Start()
    {
        clickableObject = this.gameObject;
    }

    /**
     * Description: This method executes/runs every frame
     * 
     */
    void Update()
    {
        //This uses a raycaster to get the place where you clicked
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //This sets the place where you clicked as a location
        RaycastHit Hit;

        //if you left click or press on a touchscreen
        if (Input.GetMouseButtonDown(0))
        {
            //if you have pressed the touchscreen and its location is over the object
            if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
            {
                //execute the options in the GUI drop down property.
                OnClick.Invoke();
            }
        }
    }
}
