using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class TargetSelector : MonoBehaviour
{
    public TMP_Text countText;
    public TMP_Text winText;
    public int count;
    public TMP_Text Collection;
    public GameObject TriggerObj;

    public float rayLength;
    public LayerMask layermask;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        winText.text = "";
        SetCountText();
        Collection.gameObject.SetActive(true);
        TriggerObj.gameObject.SetActive(true);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, rayLength, layermask))
            {
                Destroy(hit.collider.gameObject);
                count = count + 1;
                SetCountText();
            }
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 4)
        {
            winText.text = "Door Unlocked";
            Collection.gameObject.SetActive(false);
            TriggerObj.gameObject.SetActive(false);
        }
    }
}
