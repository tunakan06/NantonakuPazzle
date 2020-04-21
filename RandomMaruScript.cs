using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMaruScript : MonoBehaviour
{
    //　出現させる丸を入れておく
    [SerializeField] GameObject[] maru;
    public int maruCount;
    int maxMaruCount = 40;

    // Start is called before the first frame update
    void Start()
    {
        maruCount = 0;
        //maru = GameObject.FindGameObjectsWithTag("maru");
        //maruCount = maru.Length;
    }

    // Update is called once per frame
    void Update()
    {

        if ( maruCount <= maxMaruCount ) {
            AppearMaru();
        }

    }

    void AppearMaru()
    {
        int randomValue = Random.Range(0, maru.Length);
        float randomValueX = Random.Range(-2.5f, 2.5f);
        float randomValueY = Random.Range( 4.5f, 5.5f);

        GameObject.Instantiate( maru[randomValue], new Vector3(randomValueX, randomValueY), Quaternion.Euler(0f, 0f, Random.value * 360f));
        maruCount++;
        Debug.Log(maruCount);
    }

}
