using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSelector : MonoBehaviour
{
    public Canvas menuCanvas;
    public Button[] buttons = new Button[7];
    Button closestButtonToCursor;
    Transform closestImage;
    float minDistance = 9999f;

    public Color selectedColor;
    private void Awake()
    {
        //reformat
        buttons[0].onClick.AddListener(TaskOnClick1);
        buttons[1].onClick.AddListener(TaskOnClick2);
        buttons[2].onClick.AddListener(TaskOnClick3);
        buttons[3].onClick.AddListener(TaskOnClick4);
        buttons[4].onClick.AddListener(TaskOnClick5);
        buttons[5].onClick.AddListener(TaskOnClick6);
        buttons[6].onClick.AddListener(TaskOnClick7);
        buttons[7].onClick.AddListener(TaskOnClick8);
        //reformat
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Tab))
        {
            menuCanvas.enabled = true;
            handleMenu();
        }
        else
        {
            menuCanvas.enabled = false;
        }
    }

    public void handleMenu()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;


        for (int i = 0; i < buttons.Length; i++)
        {
            float distance = Mathf.Sqrt(Mathf.Pow((mousePos.x - buttons[i].transform.position.x), 2) + Mathf.Pow((mousePos.y - buttons[i].transform.position.y), 2));
            if (distance < minDistance)
            {
                minDistance = distance;
                if (closestButtonToCursor != null)
                {
                    closestImage.gameObject.GetComponent<Image>().color = Color.white;
                }

                closestButtonToCursor = buttons[i];
                closestImage = closestButtonToCursor.gameObject.transform.GetChild(0);

                closestImage.gameObject.GetComponent<Image>().color = selectedColor;
            }
        }
        minDistance = 9999f;
        print("pozicija misa: " + mousePos);
        print("najblize dugme: " + closestButtonToCursor.name);
    }

    //reformat
    public void TaskOnClick1() //buttonName=ItemName
    {
        print("You have choosen button: " + buttons[0].name);
    }
    public void TaskOnClick2() //buttonName=ItemName
    {
        print("You have choosen button: " + buttons[1].name);
    }
    public void TaskOnClick3() //buttonName=ItemName
    {
        print("You have choosen button: " + buttons[2].name);
    }
    public void TaskOnClick4() //buttonName=ItemName
    {
        print("You have choosen button: " + buttons[3].name);
    }
    public void TaskOnClick5() //buttonName=ItemName
    {
        print("You have choosen button: " + buttons[4].name);
    }
    public void TaskOnClick6() //buttonName=ItemName
    {
        print("You have choosen button: " + buttons[5].name);
    }
    public void TaskOnClick7() //buttonName=ItemName
    {
        print("You have choosen button: " + buttons[6].name);
    }
    public void TaskOnClick8() //buttonName=ItemName
    {
        print("You have choosen button: " + buttons[7].name);
    }
    //reformat
}
