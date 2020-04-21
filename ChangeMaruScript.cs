using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaruScript : MonoBehaviour
{
    public RandomMaruScript randomMaruScript;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;

        }
        if (Input.GetMouseButtonUp(0))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
            ObjectDestroy();
        }
    }

    //マウスが離れたとき
    private void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    //オブジェクトが衝突したとき
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == this.tag)
        {
            if (Input.GetMouseButtonDown(0))
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;

            }
            if (Input.GetMouseButtonUp(0))
            {
                gameObject.GetComponent<Renderer>().material.color = Color.white;
                ObjectDestroy();
            }
        }
    }

    private void ObjectDestroy()
    {
        Destroy(gameObject);
        randomMaruScript.maruCount--;
        Debug.Log(randomMaruScript.maruCount);
    }

}
