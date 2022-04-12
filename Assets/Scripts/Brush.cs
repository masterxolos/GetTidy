using System.Collections;
using System.Collections.Generic;
using PaintIn3D;
using UnityEngine;



public class Brush : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;

    private Color OrangeColor = new Color(1f, 0.501f, 0.2f);
    private Color DarkBlueColor = new Color(0f, 0, 0.5f);

    void OnMouseDown()
    {
        gameObject.transform.position =
            new Vector3(transform.position.x, transform.position.y, transform.position.z);
        mZCoord = Camera.main.WorldToScreenPoint(
            gameObject.transform.position).z;
        
        // Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

    }
    
    private Vector3 GetMouseAsWorldPoint()
    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen
        mousePoint.z = mZCoord;
        // Convert it to world points

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }
    
    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }

    private void OnMouseUp()
    {
        gameObject.transform.position =
            new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    public void onBlueClicked()
    {
        gameObject.transform.GetChild(0).gameObject.GetComponent<P3dPaintSphere>().Color = Color.blue;
    }
    public void onYellowClicked()
    {
        gameObject.transform.GetChild(0).gameObject.GetComponent<P3dPaintSphere>().Color = Color.yellow;
    }
    public void onredClicked()
    {
        gameObject.transform.GetChild(0).gameObject.GetComponent<P3dPaintSphere>().Color = Color.red;
    }
    
    public void onPurpleClicked()
    {
        gameObject.transform.GetChild(0).gameObject.GetComponent<P3dPaintSphere>().Color = Color.magenta;
    }
    
    public void onOrangeClicked()
    {
        gameObject.transform.GetChild(0).gameObject.GetComponent<P3dPaintSphere>().Color = OrangeColor;
    }

    public void onGreenClicked()
    {
        gameObject.transform.GetChild(0).gameObject.GetComponent<P3dPaintSphere>().Color = Color.green;
    }
    
    public void onDarkBlueClicked()
    {
        gameObject.transform.GetChild(0).gameObject.GetComponent<P3dPaintSphere>().Color = DarkBlueColor;
        
    }
}