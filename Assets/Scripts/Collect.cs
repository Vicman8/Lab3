using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collect : MonoBehaviour
{

    /*public TMP_Text countText;
    public TMP_Text winText;
    public float speed;
    public int count;
    public TMP_Text Collection;
    public GameObject TriggerObj;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        winText.text = "";
        SetCountText();
        Collection.gameObject.SetActive(true);
        TriggerObj.gameObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 4)
        {
            winText.text = "Door Unlocked";
            Collection.gameObject.SetActive(false);
            TriggerObj.gameObject.SetActive(false);
        }
    }

 */
}
